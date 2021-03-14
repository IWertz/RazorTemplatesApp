using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options)
        {

        }
        public DbSet<GameType> GameTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GameType>().HasData(
                new GameType { GameTypeId = 1, Name = "Winter Olympics" },
                new GameType { GameTypeId = 2, Name = "Summer Olympics" },
                new GameType { GameTypeId = 3, Name = "Paralympics" },
                new GameType { GameTypeId = 4, Name = "Youth Olympic Games" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Indoor" },
                new Category { CategoryId = 2, Name = "Outdoor" }
            );

            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = "canada", Name = "Canada", GameTypeId = 1, CategoryId = 1, CountryImage = "canada.png" },
                new Country { CountryId = "sweden", Name = "Sweden", GameTypeId = 1, CategoryId = 1, CountryImage = "sweden.png" },
                new Country { CountryId = "great", Name = "Great Britain", GameTypeId = 1, CategoryId = 1, CountryImage = "great.png" },
                new Country { CountryId = "jamaica", Name = "Jamaica", GameTypeId = 1, CategoryId = 2, CountryImage = "jamaica.png" },
                new Country { CountryId = "italy", Name = "Italy", GameTypeId = 1, CategoryId = 2, CountryImage = "italy.png" },
                new Country { CountryId = "japan", Name = "Japan", GameTypeId = 1, CategoryId = 2, CountryImage = "japan.png" },
                new Country { CountryId = "germany", Name = "Germany", GameTypeId = 2, CategoryId = 1, CountryImage = "germany.png" },
                new Country { CountryId = "china", Name = "China", GameTypeId = 2, CategoryId = 1, CountryImage = "china.png" },
                new Country { CountryId = "mexico", Name = "Mexico", GameTypeId = 2, CategoryId = 1, CountryImage = "mexico.png" },
                new Country { CountryId = "brazil", Name = "Brazil", GameTypeId = 2, CategoryId = 2, CountryImage = "brazil.png" },
                new Country { CountryId = "nether", Name = "Netherlands", GameTypeId = 2, CategoryId = 2, CountryImage = "nether.png" },
                new Country { CountryId = "usa", Name = "USA", GameTypeId = 2, CategoryId = 2, CountryImage = "usa.png" },
                new Country { CountryId = "thai", Name = "Thailand", GameTypeId = 3, CategoryId = 1, CountryImage = "thai.png" },
                new Country { CountryId = "uru", Name = "Uruguay", GameTypeId = 3, CategoryId = 1, CountryImage = "uru.png" },
                new Country { CountryId = "ukraine", Name = "Ukraine", GameTypeId = 3, CategoryId = 1, CountryImage = "ukraine.png" },
                new Country { CountryId = "austria", Name = "Austria", GameTypeId = 3, CategoryId = 2, CountryImage = "austria.png" },
                new Country { CountryId = "pakistan", Name = "Pakistan", GameTypeId = 3, CategoryId = 2, CountryImage = "Pakistan.png" },
                new Country { CountryId = "zim", Name = "Zimbabwe", GameTypeId = 3, CategoryId = 2, CountryImage = "zim.png" },
                new Country { CountryId = "france", Name = "France", GameTypeId = 4, CategoryId = 1, CountryImage = "france.png" },
                new Country { CountryId = "cyprus", Name = "Cyprus", GameTypeId = 4, CategoryId = 1, CountryImage = "cyprus.png" },
                new Country { CountryId = "russia", Name = "Russia", GameTypeId = 4, CategoryId = 1, CountryImage = "russia.png" },
                new Country { CountryId = "fin", Name = "Finland", GameTypeId = 4, CategoryId = 2, CountryImage = "fin.png" },
                new Country { CountryId = "slov", Name = "Slovakia", GameTypeId = 4, CategoryId = 2, CountryImage = "slov.png" },
                new Country { CountryId = "portugal", Name = "Portugal", GameTypeId = 4, CategoryId = 2, CountryImage = "portugal.png" }
            );
        }
    }
}
