using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PhoneApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp.ViewModels
{
    public partial class HomePageViewModel:ObservableObject
    {
        public HomePageViewModel() 
        {
            MonthList = new ObservableCollection<HomeGuidanceMonth>
            {
              new HomeGuidanceMonth(){Index=1,Value="2022-08",IsChecked=false,Margin=new Thickness(50,0,0,0)},
              new HomeGuidanceMonth(){Index=2,Value="2022-09",IsChecked=false,Margin=new Thickness(0,0,0,0)},
              new HomeGuidanceMonth(){Index=3,Value="2022-10",IsChecked=true,Margin=new Thickness(0,0,0,0)},
              new HomeGuidanceMonth(){Index=4,Value="2022-11",IsChecked=false,Margin=new Thickness(0,0,0,0)},
              new HomeGuidanceMonth(){Index=5,Value="2022-12",IsChecked=false,Margin=new Thickness(0,0,50,0)},
            };

            NavItemList = new List<string>()
            {
                "店铺信息",
                "活动信息",
                "客户信息",
                "材质信息",
                "仓库"
            };
        }

        [ObservableProperty]
        private ObservableCollection<HomeGuidanceMonth> monthList;

        [ObservableProperty]
        private List<string> navItemList;

        [RelayCommand]
        public async void NavTo(string title)
        {
            await Shell.Current.GoToAsync(title, false);
        }
    }

    
}
