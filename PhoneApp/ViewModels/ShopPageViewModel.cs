using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PhoneApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp.ViewModels
{
    public partial class ShopPageViewModel: ObservableObject
    {
        ShopPage thisPage;
        public ShopPageViewModel(ShopPage page)
        {
            thisPage = page;
            SearchKey = string.Empty;
        }

        [ObservableProperty]
        private double frameWidth;

        [ObservableProperty]
        private Thickness frameMargin;

        [ObservableProperty]
        private bool showConver;

        [RelayCommand]
        public void OpenSearchMore()
        {
            thisPage.ShowSearchFrame();
        }

        [RelayCommand]
        public void CloseSearchMore()
        {
            thisPage.CloseSearchFrame();
        }

        [RelayCommand]
        public void ClearSearch()
        {
            SearchKey = string.Empty;
        }

        #region 搜索
        [ObservableProperty]
        private string searchKey;

        public void DoSearch(string searchKey)
        {
            SearchKey = searchKey;
        }

        #endregion


        #region 筛选条件
        [ObservableProperty]
        private List<string> customerList;

        [ObservableProperty]
        private List<string> regionList;

        [ObservableProperty]
        private List<string> provinceList;

        [ObservableProperty]
        private List<string> cityTierList;

        [ObservableProperty]
        private List<string> channelList;

        [ObservableProperty]
        private List<string> formatList;

        [ObservableProperty]
        private List<string> installList;

        public void InitSearchConditions()
        {
            CustomerList = new List<string> { "阿迪达斯", "锐步", "长城", "派克" };
            RegionList = new List<string> { "North", "West", "South", "East" };
            CityTierList = new List<string> { "T0", "T1", "T2", "T3", "T4", "T5", "T6", "T7" };
            ChannelList = new List<string> { "Homecourt", "Kids", "Core" };
            FormatList = new List<string> { "HC", "HCS", "Kids-YA", "Kids-新", "Kids-S", "Core-1.0", "Core-2.0" };
            InstallList = new List<string> { "Y", "N" };

        }


        #endregion

        #region 下拉刷新
        [ObservableProperty]
        private bool isFreshing;

        [RelayCommand]
        public async void DoFresh()
        {
            IsFreshing = true;
            await Task.Delay(2000);
            IsFreshing = false;
        }
        #endregion

        [RelayCommand]
        public void GoDetial(string shopId)
        {
            Dictionary<string, object> param = new Dictionary<string, object>
            {
                { "ShopId",shopId}
            };
            Shell.Current.GoToAsync(nameof(ShopInfoPage), true, param);
        }
    }
}
