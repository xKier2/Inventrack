namespace Inventrack;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnInventoryTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(InventoryPage));
    }
}