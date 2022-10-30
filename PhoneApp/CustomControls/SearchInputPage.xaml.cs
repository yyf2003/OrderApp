

namespace PhoneApp.CustomControls;


[QueryProperty(nameof(SearchKey), nameof(SearchKey))]
[QueryProperty(nameof(Placeholder), nameof(Placeholder))]
public partial class SearchInputPage : ContentPage
{
	public SearchInputPage()
	{
		InitializeComponent();
	}

    public string SearchKey { get; set; }
    public string Placeholder { get; set; }

    /// <summary>
    /// 必须重载这个方法来接受传过来的参数
    /// </summary>
    /// <param name="args"></param>
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        TextInput.Text = SearchKey;
        TextInput.Placeholder = Placeholder;

    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        TextInput.Unfocus();
    }

    private void OnSearch_Click(object sender, EventArgs e)
    {
        string searchText = TextInput.Text;
        if (!string.IsNullOrEmpty(searchText))
        {
            Shell.Current.GoToAsync("..", false, new Dictionary<string, object> { { "NewSearchKey", searchText } });
        }
    }

    private void btn_back_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..", false);
    }

   
}