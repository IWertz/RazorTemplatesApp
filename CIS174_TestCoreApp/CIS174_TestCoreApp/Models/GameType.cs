using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class GameType
    {
        public int GameTypeId { get; set; }
        public string Name { get; set; }
    }
}
