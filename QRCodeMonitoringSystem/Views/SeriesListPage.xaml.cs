using QRCodeMonitoringSystem.ViewModels;
namespace QRCodeMonitoringSystem.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class SeriesListPage : ContentPage
{
	public SeriesListPage()
	{
		InitializeComponent();
        BindingContext = ViewModel = new ItemsViewModel();
    }

    ItemsViewModel ViewModel { get; }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ViewModel.OnAppearing();
    }
}