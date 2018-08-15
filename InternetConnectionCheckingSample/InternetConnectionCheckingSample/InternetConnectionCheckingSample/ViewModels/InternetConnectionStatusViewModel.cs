using Plugin.Connectivity;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace InternetConnectionCheckingSample.ViewModels
{
    public class InternetConnectionStatusViewModel : INotifyPropertyChanged
    {
        public InternetConnectionStatusViewModel()
        {
            CheckNetworkOnStart();

            NetworkContinousely();
        }

        private string _internetStatus;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs((propertyName)));
        }

        public string NetWorkStatus
        {
            get { return _internetStatus; }
            set
            { _internetStatus = value;
                OnPropertyChanged();
            }
        }

        private void CheckNetworkOnStart()
        {
            NetWorkStatus = CrossConnectivity.Current.IsConnected ? "Good Internet Connectios" : "Check Internet Connection";
        }

        private void NetworkContinousely()
        {
            CrossConnectivity.Current.ConnectivityChanged += (sender, args) =>
            {
                NetWorkStatus = args.IsConnected ? "Good Internet Connectios" : "Check Internet Connection";
            };
        }
    }
}
