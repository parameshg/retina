using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;

namespace Retina.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScannerView : ContentPage
    {
        public ScannerView()
        {
            InitializeComponent();
        }

        public void OnScan(object sender, EventArgs args)
        {
        }

        public void OnScanned(Result result)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await DisplayAlert("Scanner", result.Text, "OK");

                //await DisplayActionSheet("Scanned", "Cancel", "Destroy", "1", "2");
            });
        }
    }
}