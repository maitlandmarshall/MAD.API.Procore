using MAD.API.Procore.Gen;
using MAD.API.Procore.GenUI.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;

namespace MAD.API.Procore.GenUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel ViewModel
        {
            get => this.DataContext as MainWindowViewModel;
        }

        public MainWindow()
        {
            this.InitializeComponent();
            this.WindowState = WindowState.Maximized;

            this.DataContext = new MainWindowViewModel();
            this.ViewModel.PropertyChanged += this.ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            
        }

        protected override async void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            IEnumerable<GroupModel> groups = await RemoteJsonFile.GetJsonFile<IEnumerable<GroupModel>>("groups");
            IDictionary<string, Schema> allSchemas = new Dictionary<string, Schema>();

            List<EndpointGroup> result = new List<EndpointGroup>();

            foreach (GroupModel grp in groups)
            {
                bool alreadySnakeCase = new Regex("/^[a-z_]*$/").IsMatch(grp.Name);

                string gelatoGroup = alreadySnakeCase ?
                    grp.Name :
                    grp.Name.Replace(" ", "-").ToLower();

                IEnumerable<Endpoint> endpoints = await RemoteJsonFile.GetJsonFile<IEnumerable<Endpoint>>(gelatoGroup);

                result.AddRange(endpoints
                    .GroupBy(y => y.Group)
                    .Select(y => new EndpointGroup
                    {
                        Group = y.Key,
                        Endpoints = y.AsEnumerable()
                    }));
            }

            this.ViewModel.Endpoints = result.OrderBy(y => y.Group);
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            Endpoint endpoint = e.NewValue as Endpoint;

            if (endpoint is null)
                return;

            EndpointResponse okResponse = endpoint.Responses.FirstOrDefault(y => y.Status == 200);
            IEnumerable<Schema> schemas = this.GetNestedSchemas(okResponse.Schema);

            var classes = new Dictionary<string, string>();

            foreach (Schema s in schemas)
            {
                string className = ClassNameFactory.Create(s);

                if (className is null)
                    continue;

                string code = CSGen.Generate(s, "MAD.API.Procore.Models", className);

                if (code is null)
                    continue;

                classes.TryAdd(className, code);
            }

            this.ViewModel.Code = string.Join(Environment.NewLine, classes.Values);
        }

        private IEnumerable<Schema> GetNestedSchemas(Schema schemaModel)
        {
            if (schemaModel.Type.Name == "object"
                || schemaModel.Type.Name == "array")
                yield return schemaModel;

            if (schemaModel.Properties != null)
            {
                foreach (ISchemaProperty s in schemaModel.Properties)
                {
                    foreach (Schema ns in this.GetNestedSchemas(s as Schema))
                        yield return ns;
                }
            }

            if (schemaModel.Items != null)
            {
                foreach (Schema s in this.GetNestedSchemas(schemaModel.Items as Schema))
                    yield return s;
            }
        }
    }
}
