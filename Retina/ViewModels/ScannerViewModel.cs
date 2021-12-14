using System.Windows.Input;
using Xamarin.Forms;

namespace Retina.ViewModels
{
    public class ScannerViewModel
    {
        public bool IsScanning { get; set; }

        public ICommand ScanCommand { get; }

        public ScannerViewModel()
        {
            ScanCommand = new Command(() => IsScanning = true);
        }
    }
}