using PhoneApp.ViewModels;

namespace PhoneApp.Views;

public partial class AddShopPage : ContentPage
{
    AddShopPageViewModel viewModel;
	public AddShopPage()
	{
		InitializeComponent();
        BindingContext = viewModel = new AddShopPageViewModel();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..", true);
    }
}