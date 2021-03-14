using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class Country
    {
        public string CountryId { get; set; }
        public string Name { get; set; }
        public int GameTypeId { get; set; }
        public GameType GameType { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string CountryImage { get; set; }
    }
}
