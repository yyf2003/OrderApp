using ClientApp.PopupViews;
using ClientApp.ViewModels;
using CommunityToolkit.Maui.Views;
using MauiPopup;

namespace ClientApp.Views;

[QueryProperty(nameof(NewSearchKey),nameof(NewSearchKey))]
public partial class ShopPage : ContentPage
{
    ShopPageViewModel viewModel;
    public ShopPage()
	{
		InitializeComponent();
        BindingContext=viewModel=new ShopPageViewModel(this);
    }

    public string NewSearchKey { get; set; }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        if(!string.IsNullOrEmpty(NewSearchKey))
        {
            viewModel.DoSearch(NewSearchKey);
        }
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..",true);
       //await  App.Current.MainPage.Navigation.PopAsync();
    }

    
    public async void ShowSearchFrame()
    {
        uint animationDuration = 100u;
        //SearchFrame.Animate("f",
        //    value =>
        //    {
        //        int scale = Convert.ToInt32(value * 10);
        //        var margin = !viewModel.ShowConver ? (scale * 10) - 105 : ((scale * 10)+200) * -1;
        //        return new Thickness(0, 0, margin, 0);
        //    },
        //    newThickness => SearchFrame.Margin = newThickness,
        //    length: animationDuration,
        //    finished:(_,_)=> viewModel.ShowConver = !viewModel.ShowConver
        //);
        //await SearchFrame.TranslateTo(!viewModel.ShowConver ? -(viewModel.FrameWidth-5) : 0, 0, animationDuration);
        await SearchFrame.TranslateTo(-(viewModel.FrameWidth - 5), 0, animationDuration);
        viewModel.ShowConver = true;
    }

    public async void CloseSearchFrame()
    {
        uint animationDuration = 100u;
        await SearchFrame.TranslateTo (0, 0, animationDuration);
        viewModel.ShowConver=false;
    }
}