using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string ShopNo { get; set; }
        public string ShopName { get; set; }
        public string Region { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string CityTier { get; set; }

        public string SPInstall { get; set; }
        public string BCSInstall { get; set; }
        public string GPInstall { get; set; }
        public string Contact1 { get; set; }
        public string Tel1 { get; set; }
        public string Contact2 { get; set; }
        public string Tel2 { get; set; }
        public string Address { get; set; }

        public int SPReceiveInstallFee { get; set; }
        public int SPPayInstallFee { get; set;}
        public int BCSReceiveInstallFee { get; set; }
        public int BCSPayInstallFee { get; set; }
        public int GPReceiveInstallFee { get; set; }
        public int GPPayInstallFee { get; set; }

        public int ReceiveLajiFee { get; set; }
        public int PayLajiFee { get; set; }
        public int ReceiveShigongFee { get; set; }
        public int PayShigongFee { get; set; }
        public string InstallOutsource { get; set; }
        public string ProduceOutsource { get; set; }
        public string Remark { get; set; }

    }
}
