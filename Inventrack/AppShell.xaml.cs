namespace Inventrack
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(InventoryPage), typeof(InventoryPage));
        }
    }
}
