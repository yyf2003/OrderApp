using CommunityToolkit.Mvvm.ComponentModel;
using PhoneApp.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp.ViewModels
{
    public partial class AddShopPageViewModel:ObservableObject
    {
        public AddShopPageViewModel()
        {
            CustomerSelectList = new List<SelectPickerModel>
            {
                new SelectPickerModel{Id=1,Value="阿迪达斯"  },
                new SelectPickerModel{Id=2,Value="锐步"  },
                new SelectPickerModel{Id=3,Value="物美"  },
                new SelectPickerModel{Id=4,Value="李宁"  }
            };
        }

        [ObservableProperty]
        private List<SelectPickerModel> customerSelectList;

        [ObservableProperty]
        private SelectPickerModel selectedCustomer;
    }
}
