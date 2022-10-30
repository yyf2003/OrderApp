using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string PlaceName { get; set; }
        public int ParentId { get; set; }
        public int RegionId { get; set; }
    }
}
