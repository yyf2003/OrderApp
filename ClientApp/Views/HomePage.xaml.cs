
using ClientApp.ViewModels;
using System;

namespace ClientApp.Views;

public partial class HomePage : ContentView
{
    //HomePageViewModel viewModel;
    public HomePage()
	{
        InitializeComponent();
        //BindingContext = viewModel = new HomePageViewModel();
        //timer = new System.Timers.Timer(1000);
        //timer.Elapsed += Timer_Elapsed;
        //timer.Start();
    }

    //private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    //{
    //    App.Current.Dispatcher.DispatchAsync(() =>
    //    {
    //        SetScroll();
    //    });
    //    timer.Stop();
    //    timer.Dispose();
    //    timer = null;
    //}

    //System.Timers.Timer timer;

 //   public async void SetScroll()
	//{
 //       //await month_ScrollView.ScrollToAsync(months, ScrollToPosition.Center, true);
 //       int index = viewModel.MonthList.FirstOrDefault(s => s.IsChecked).Index;
 //       var w = 60;
 //       double x = ((index-1)*w)+((index-1)*20);
 //       await month_ScrollView.ScrollToAsync(x, 0, true);
 //   }

 //   private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
 //   {
 //       SetScroll();
 //   }

}