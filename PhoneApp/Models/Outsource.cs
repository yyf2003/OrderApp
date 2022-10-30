﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp.Models
{
    public class Outsource
    {
        public int Id { get; set; }
        public string OutsourceName { get; set; }
        public int RegionId { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
    }
}
