using PhoneApp.Views;

namespace PhoneApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ShopPage), typeof(ShopPage));
            Routing.RegisterRoute(nameof(ShopInfoPage), typeof(ShopInfoPage));
            Routing.RegisterRoute(nameof(AddShopPage), typeof(AddShopPage));
        }
    }
}