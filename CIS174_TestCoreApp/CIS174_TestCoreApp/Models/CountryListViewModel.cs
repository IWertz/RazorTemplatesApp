using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class CountryListViewModel : CountryViewModel
    {
        public List<Country> Countries { get; set; }

        private List<GameType> games;
        public List<GameType> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0, new GameType { GameTypeId = 0, Name = "All" });
            }
        }

        private List<Category> categories;
        public List<Category> Categories
        {
            get => categories;
            set
            {
                categories = value;
                categories.Insert(0, new Category { CategoryId = 0, Name = "All" });
            }
        }

        public string CheckActiveGame(string g) =>
            g.ToLower() == ActiveGame.ToLower() ? "active" : "";

        public string CheckActiveCat(string c) =>
            c.ToLower() == ActiveCat.ToLower() ? "active" : "";
    }
}
