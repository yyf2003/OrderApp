using ClientApp.CustomControls;
using ClientApp.Views;

namespace ClientApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ShopPage), typeof(ShopPage));
            Routing.RegisterRoute(nameof(SearchInputPage), typeof(SearchInputPage));
            Routing.RegisterRoute(nameof(ShopInfoPage), typeof(ShopInfoPage));
        }


    }
}