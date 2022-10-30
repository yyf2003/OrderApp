namespace ClientApp.Views;

public partial class ShopMachineFrameView : ContentView
{
	public ShopMachineFrameView(int shopId)
	{
		InitializeComponent();
        ShopId = shopId;
    }

    public int ShopId { get; set; }
}