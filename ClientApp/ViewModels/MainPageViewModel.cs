using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.ViewModels
{
    public partial class MainPageViewModel:ObservableObject
    {
        public MainPageViewModel()
        {
            HomePageViewModel=new HomePageViewModel();
        }

        [ObservableProperty]
        private int _selectedViewModelIndex=0;

        [ObservableProperty]
        private HomePageViewModel _homePageViewModel;

      
    }
}
