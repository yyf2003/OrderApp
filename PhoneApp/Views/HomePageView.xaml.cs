namespace PhoneApp.Views;

public partial class HomePageView : ContentView
{
	public HomePageView()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(ShopPage),true);
    }
}