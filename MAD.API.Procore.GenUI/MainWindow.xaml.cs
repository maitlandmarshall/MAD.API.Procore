using CSCodeGen;
using MAD.API.Procore.Gen;
using MAD.API.Procore.GenUI.CodeGeneration;
using MAD.API.Procore.GenUI.Endpoints;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;

namespace MAD.API.Procore.GenUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel ViewModel
        {
            get => DataContext as MainWindowViewModel;
        }

        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;

            DataContext = new MainWindowViewModel();
            ViewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var vm = sender as MainWindowViewModel;

            if (e.PropertyName == nameof(MainWindowViewModel.SearchText))
            {
                if (string.IsNullOrEmpty(vm.SearchText))
                {
                    vm.EndpointFilter = null;
                }
                else
                {
                    vm.EndpointFilter = y => y.Group.ToLower().Contains(vm.SearchText.ToLower());
                }
            }
        }

        protected override async void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            IEnumerable<GroupModel> groups = await RemoteJsonFile.GetJsonFile<IEnumerable<GroupModel>>("groups");
            List<EndpointGroup> result = new List<EndpointGroup>();

            foreach (GroupModel grp in groups)
            {
                bool alreadySnakeCase = new Regex("/^[a-z_]*$/").IsMatch(grp.Name);

                string gelatoGroup = alreadySnakeCase ?
                    grp.Name :
                    grp.Name.Replace(" ", "-").ToLower();

                var definition = await RemoteJsonFile.GetJsonFile<ApiDefinition>(gelatoGroup);
                var endpoints = definition.Versions.First(y => y.Version == 1).Endpoints;

                foreach (var ep in endpoints)
                {
                    foreach (var r in ep.Responses)
                    {
                        SetSchemaReferences(r.Schema, ep);
                    }
                }


                result.AddRange(endpoints
                    .GroupBy(y => y.Group)
                    .Select(y => new EndpointGroup
                    {
                        Group = y.Key,
                        Endpoints = y.AsEnumerable()
                    }));
            }

            ViewModel.Endpoints = result.OrderBy(y => y.Group);
        }

        private void SetSchemaReferences(Schema schema, Endpoint ep)
        {
            if (schema is null)
                return;

            schema.Endpoint = ep;

            if (schema.Properties != null)
            {
                foreach (var s in schema.Properties)
                {
                    (s as Schema).Parent = schema;
                    SetSchemaReferences(s as Schema, ep);
                }
            }

            if (schema.Items != null)
            {
                (schema.Items as Schema).Parent = schema;
                SetSchemaReferences(schema.Items as Schema, ep);
            }
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            Endpoint endpoint = e.NewValue as Endpoint;

            if (endpoint is null)
                return;

            var gen = RequestCSGen.Generate(endpoint);

            ViewModel.Code = string.Join(Environment.NewLine, gen.Select(z => ClassSerialization.Serialize(z)));
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var endpoint = tv.SelectedItem as Endpoint;

            if (endpoint is null)
                return;

            var filesToGenerate = RequestCSGen.Generate(endpoint);
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var baseDirectory = dialog.SelectedPath;

                foreach (var f in filesToGenerate)
                {
                    var ns = f.Namespace;
                    ns = ns.Replace("MAD.API.Procore.", "");
                    ns = ns.Replace(".", "\\");

                    var fullFilePath = Path.Combine(baseDirectory, ns, $"{f.Name}.cs");

                    Directory.CreateDirectory(Path.GetDirectoryName(fullFilePath));
                    await File.WriteAllTextAsync(fullFilePath, ClassSerialization.Serialize(f));
                }
            }
        }
    }
}
