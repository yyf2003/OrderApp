using PhoneApp.ViewModels;

namespace PhoneApp.Views;

[QueryProperty(nameof(NewSearchKey), nameof(NewSearchKey))]
public partial class ShopPage : ContentPage
{
    ShopPageViewModel viewModel;
	public ShopPage()
	{
		InitializeComponent();
        BindingContext = viewModel = new ShopPageViewModel(this);
    }

    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();
        
    //}

    

    public string NewSearchKey { get; set; }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        if (!string.IsNullOrEmpty(NewSearchKey))
        {
            viewModel.DoSearch(NewSearchKey);
        }
        App.Current.Dispatcher.Dispatch(() => {
            double width = DeviceDisplay.Current.MainDisplayInfo.Width;
            double density = DeviceDisplay.Current.MainDisplayInfo.Density;
            viewModel.FrameWidth = width / density - 50;
            viewModel.FrameMargin = new Thickness(0, 0, -viewModel.FrameWidth, 0);
            viewModel.InitSearchConditions();
        });
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..", true);
        //await  App.Current.MainPage.Navigation.PopAsync();
    }


    public async void ShowSearchFrame()
    {
        uint animationDuration = 100u;
        await SearchFrame.TranslateTo(-(viewModel.FrameWidth - 5), 0, animationDuration);
        viewModel.ShowConver = true;
    }

    public async void CloseSearchFrame()
    {
        uint animationDuration = 100u;
        await SearchFrame.TranslateTo(0, 0, animationDuration);
        viewModel.ShowConver = false;
    }

    private void btnAddShop_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddShopPage),true);
    }
}