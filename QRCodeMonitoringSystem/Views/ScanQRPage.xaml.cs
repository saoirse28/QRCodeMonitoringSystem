using ZXing.Net.Maui;

namespace QRCodeMonitoringSystem.Views;

public partial class ScanQRPage : ContentPage
{
	public ScanQRPage()
	{
		InitializeComponent();
        barcodeView.Options = new BarcodeReaderOptions
        {
            Formats = BarcodeFormats.All,
            AutoRotate = true,
            Multiple = false
        };
        barcodeView.IsDetecting = false;
    }

    void SwitchCameraButton_Clicked(object sender, EventArgs e)
    {
        barcodeView.CameraLocation = barcodeView.CameraLocation == CameraLocation.Rear ? CameraLocation.Front : CameraLocation.Rear;
    }

    async void TorchButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(QRDetailPage));
        //barcodeView.IsTorchOn = !barcodeView.IsTorchOn;
    }

    void StartScanning_Clicked(object sender, EventArgs e)
    {
        barcodeView.IsDetecting = true;        
    }

    private void BarcodeView_BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        barcodeView.IsDetecting = false;
    }
}