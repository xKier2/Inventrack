namespace Inventrack;

public partial class InventoryPage : ContentPage
{
    public InventoryPage()
    {
        InitializeComponent();
    }

    private async void OnHomeTapped(object sender, EventArgs e)
    {
        // Returns back to the previous screen (Home)
        await Shell.Current.GoToAsync("..");
    }
}