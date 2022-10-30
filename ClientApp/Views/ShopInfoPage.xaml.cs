using Sharpnado.Tabs;

namespace ClientApp.Views;

public partial class ShopInfoPage : ContentPage
{
    public ShopInfoPage()
    {
        InitializeComponent();
        ViewList = new Dictionary<int, ContentView>()
        {{0,new ShopDetailView(1) } ,
        {1,new ShopPOPView(1) } ,
        {2,new ShopMachineFrameView(1) }};
        TabTo(0);
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    Dictionary<int, ContentView> ViewList;

    private void TabHostSegmented_SelectedTabIndexChanged(object sender, SelectedPositionChangedEventArgs e)
    {
        int index = (sender as TabHostView).SelectedIndex;
        TabTo(index);
    }

    void TabTo(int index)
    {
        ContentElement.Content = ViewList[index];
    }
}