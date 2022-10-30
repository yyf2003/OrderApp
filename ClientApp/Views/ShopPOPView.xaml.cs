namespace ClientApp.Views;

public partial class ShopPOPView : ContentView
{
	public ShopPOPView(int shopId)
	{
		InitializeComponent();
		ShopId=shopId;
	}

    public int ShopId { get; set; }
}