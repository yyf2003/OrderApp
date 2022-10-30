
using System.Windows.Input;
namespace PhoneApp.CustomControls;

public partial class SearchControl : ContentView
{
	public SearchControl()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty SearchKeyProperty = BindableProperty.Create(
       propertyName: nameof(SearchKey),
       returnType: typeof(string),
       declaringType: typeof(SearchControl),
       propertyChanged: SearchKeyPropertyChanged,
       defaultBindingMode: BindingMode.TwoWay
       );

    private static void SearchKeyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        SearchControl control = bindable as SearchControl;
        if (newValue != null && !string.IsNullOrEmpty(newValue.ToString()))
        {
            control.lab_placeholder.IsVisible = false;
            control.frame_inputtext.IsVisible = true;
        }
        else
        {
            control.lab_placeholder.IsVisible = true;
            control.frame_inputtext.IsVisible = false;
        }
    }

    public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(
        propertyName: nameof(Placeholder),
        returnType: typeof(string),
        declaringType: typeof(SearchControl),
        defaultBindingMode: BindingMode.OneWay
        );

    public static readonly BindableProperty ClearSearchCommandProperty = BindableProperty.Create(
        propertyName: nameof(ClearSearchCommand),
        returnType: typeof(ICommand),
        declaringType: typeof(SearchControl),
        defaultBindingMode: BindingMode.TwoWay
        );


    public string SearchKey
    {
        get => (string)GetValue(SearchKeyProperty);
        set => SetValue(SearchKeyProperty, value);
    }

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    public ICommand ClearSearchCommand
    {
        get => (ICommand)GetValue(ClearSearchCommandProperty);
        set => SetValue(ClearSearchCommandProperty, value);
    }

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"SearchInputPage?SearchKey={SearchKey}&Placeholder={Placeholder}", false);
    }

    private void DeleteInputText_Tapped(object sender, EventArgs e)
    {
        ClearSearchCommand?.Execute(null);
    }
}