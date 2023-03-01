namespace QRCodeMonitoringSystem.Views;

public partial class HomeScanPage : ContentPage
{
	public HomeScanPage()
	{
		InitializeComponent();
	}

    async void StartQRScan_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(ScanQRPage));
    }

    async void ManualInput_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(QRDetailPage));
    }
}