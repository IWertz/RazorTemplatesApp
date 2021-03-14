using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class CountryViewModel
    {
        public Country Country { get; set; }
        public string ActiveGame { get; set; } = "0";
        public string ActiveCat { get; set; } = "0";
    }
}
