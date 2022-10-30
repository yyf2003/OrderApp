using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp.ViewModels
{
    [QueryProperty(nameof(ShopId), nameof(ShopId))]
    public partial class ShopInfoViewModel:ObservableObject
    {
        public ShopInfoViewModel()
        {
            int shopId0=0;
            //int.TryParse(ShopId, out shopId);
            ShopDetailViewModel =new ShopDetailViewModel(shopId0);
            ShopPOPViewModel=new ShopPOPViewModel(shopId0);
            ShopMachineFrameViewModel=new ShopMachineFrameViewModel(shopId0);
        }

        [ObservableProperty]
        private int _shopId;

        [ObservableProperty]
        private int _selectedViewModelIndex = 0;

        [ObservableProperty]
        private ShopDetailViewModel _shopDetailViewModel;
        [ObservableProperty]
        private ShopPOPViewModel _shopPOPViewModel;
        [ObservableProperty]
        private ShopMachineFrameViewModel _shopMachineFrameViewModel;

    }
}
