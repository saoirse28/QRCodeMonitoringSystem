using DevExpress.Maui.CollectionView;
using QRCodeMonitoringSystem.ViewModels;

namespace QRCodeMonitoringSystem.Views
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ScanQRPage), typeof(ScanQRPage));
            Routing.RegisterRoute(nameof(QRDetailPage), typeof(QRDetailPage));
            Routing.RegisterRoute(nameof(AddCustomField), typeof(AddCustomField));
        }

        async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Current.GoToAsync("//LoginPage");
        }

        void OnCloseClicked(object sender, EventArgs e)
        {
            Current.FlyoutIsPresented = false;
        }
    }
}