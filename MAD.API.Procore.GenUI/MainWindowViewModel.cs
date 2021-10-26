using MAD.API.Procore.GenUI.Endpoints;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MAD.API.Procore.GenUI
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        private IEnumerable<EndpointGroup> endpoints;
        private string code;
        private string searchText;
        private Func<EndpointGroup, bool> endpointFilter;

        public IEnumerable<EndpointGroup> Endpoints
        {
            get
            {
                if (EndpointFilter != null)
                {
                    return endpoints.Where(EndpointFilter);
                }
                else
                {
                    return endpoints;
                }
            }
            set
            {
                endpoints = value;
                OnPropertyChanged();
            }
        }

        public Func<EndpointGroup, bool> EndpointFilter
        {
            get => endpointFilter;
            set
            {
                endpointFilter = value;
                OnPropertyChanged(nameof(Endpoints));
            }
        }

        public string Code
        {
            get => code;
            set
            {
                code = value;
                OnPropertyChanged();
            }
        }

        public string SearchText
        {
            get => searchText;
            set
            {
                searchText = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    internal class EndpointGroup
    {
        public string Group { get; set; }
        public IEnumerable<Endpoint> Endpoints { get; set; }
    }
}
