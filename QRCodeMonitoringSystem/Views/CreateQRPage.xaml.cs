namespace QRCodeMonitoringSystem.Views;

public partial class CreateQRPage : ContentPage
{
	public CreateQRPage()
	{
		InitializeComponent();
	}

    async void AddCustomDetail_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddCustomField));
    }
}