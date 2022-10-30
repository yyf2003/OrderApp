using Microsoft.Maui.Controls;

namespace PhoneApp.CustomControls;

public partial class SelectPicker : ContentView
{
	public SelectPicker()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        propertyName:nameof(Title),
        returnType:typeof(string),
        declaringType:typeof(SelectPicker),
        propertyChanged: TitlePropertyChanged,
        defaultBindingMode: BindingMode.OneWay
        );

    private static void TitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        SelectPicker control= bindable as SelectPicker;
        if(newValue!=null)
        {
            control.InputBox.Placeholder = $"«Î—°‘Ò{newValue}";
        }
    }

    public static readonly BindableProperty ItemsProperty = BindableProperty.Create(
        propertyName:nameof(Items),
        returnType: typeof(List<SelectPickerModel>),
        declaringType:typeof(SelectPicker),
        defaultBindingMode: BindingMode.TwoWay
        );

    public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create(
        propertyName:nameof(SelectedItem),
        returnType:typeof(SelectPickerModel),
        declaringType:typeof(SelectPicker),
        propertyChanged: SelectedItemPropertyChanged,
        defaultBindingMode: BindingMode.TwoWay
        );

    private static void SelectedItemPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        SelectPicker control= bindable as SelectPicker;
        if(newValue!=null)
        {
            control.InputBox.Text = ((SelectPickerModel)newValue).Value;
        }
    }

    public string Title
    {
        get=>(string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public List<SelectPickerModel> Items
    {
        get=> (List<SelectPickerModel>)GetValue(ItemsProperty);
        set => SetValue(ItemsProperty, value);
    }

    public SelectPickerModel SelectedItem
    {
        get=>(SelectPickerModel)GetValue(SelectedItemProperty);
        set => SetValue(SelectedItemProperty, value);
    }

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        List<string> items = new List<string>();
        if(Items!=null && Items.Any())
        {
            items = Items.Select(s => s.Value).ToList();
        }
        string selected = await App.Current.MainPage.DisplayActionSheet(Title, "»°œ˚", null,FlowDirection.MatchParent, items.ToArray());
        if(selected!=null)
        {
            SelectedItem= Items.FirstOrDefault(f => f.Value==selected);
        }
    }
}