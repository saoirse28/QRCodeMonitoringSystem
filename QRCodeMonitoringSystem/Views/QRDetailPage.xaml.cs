namespace QRCodeMonitoringSystem.Views;

public partial class QRDetailPage : ContentPage
{
	public QRDetailPage()
	{
		InitializeComponent();
	}

    async void AddCustomDetail_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(AddCustomField));
    }
}