using Retina.Services;
using Retina.Views;
using Xamarin.Forms;

namespace Retina
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<Endpoint>();

            MainPage = new ScannerView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}