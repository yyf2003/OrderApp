using CommunityToolkit.Maui.Views;
using MauiPopup.Views;

namespace ClientApp.PopupViews;

public partial class SearchShopView : BasePopupPage
{
	public SearchShopView()
	{
		InitializeComponent();
		double height = DeviceDisplay.Current.MainDisplayInfo.Height;
		double width = DeviceDisplay.Current.MainDisplayInfo.Width;
		double density = DeviceDisplay.Current.MainDisplayInfo.Density;


		MainContent.WidthRequest = width / density - 10;
		MainContent.HeightRequest = height/ density;
	}
}