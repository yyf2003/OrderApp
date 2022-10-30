using PhoneApp.ViewModels;
using Sharpnado.Tabs;
using System.Linq.Expressions;

namespace PhoneApp.Views;

public partial class ShopInfoPage : ContentPage
{
	public ShopInfoPage()
	{
		InitializeComponent();
        BindingContext = new ShopInfoViewModel();
    }

    

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

    //void TabTo(int index)
    //{
    //    ContentElement.Content = ViewList[index];
    //}

    //private void TabHostSegmented_SelectedTabIndexChanged(object sender, SelectedPositionChangedEventArgs e)
    //{
    //    int index = (sender as TabHostView).SelectedIndex;
    //    TabTo(index);
    //}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}