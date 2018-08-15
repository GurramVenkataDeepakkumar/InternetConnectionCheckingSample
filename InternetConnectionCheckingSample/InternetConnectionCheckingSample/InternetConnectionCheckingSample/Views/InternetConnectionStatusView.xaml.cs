using InternetConnectionCheckingSample.ViewModels;
using Xamarin.Forms.Xaml;

namespace InternetConnectionCheckingSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InternetConnectionStatusView
    {
        public InternetConnectionStatusView()
        {
            InitializeComponent();

            BindingContext = new InternetConnectionStatusViewModel();
        }
    }
}