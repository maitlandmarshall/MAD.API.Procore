using MAD.API.Procore.GenUI.Endpoints;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MAD.API.Procore.GenUI
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        private IEnumerable<EndpointGroup> endpoints;
        private string code;
        private string searchText;

        public IEnumerable<EndpointGroup> Endpoints
        {
            get => endpoints;
            set
            {
                this.endpoints = value;
                this.OnPropertyChanged();
            }
        }

        public string Code
        {
            get => code;
            set
            {
                this.code = value;
                this.OnPropertyChanged();
            }
        }

        public string SearchText
        {
            get => searchText;
            set
            {
                this.SearchText = value;
                this.OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    internal class EndpointGroup
    {
        public string Group { get; set; }
        public IEnumerable<Endpoint> Endpoints { get; set; }
    }
}
