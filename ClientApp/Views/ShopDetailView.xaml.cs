namespace ClientApp.Views;

public partial class ShopDetailView : ContentView
{
	public ShopDetailView(int shopId)
	{
		InitializeComponent();
        ShopId = shopId;
    }

	public int ShopId { get; set; }
}