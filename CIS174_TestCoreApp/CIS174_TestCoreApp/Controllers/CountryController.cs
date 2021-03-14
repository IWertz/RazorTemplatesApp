using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CIS174_TestCoreApp.Controllers
{
    public class CountryController : Controller
    {
        private CountryContext context;

        public CountryController(CountryContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index(string activeGame = "0", string activeCat = "0")
        {
            var model = new CountryListViewModel
            {
                ActiveGame = activeGame,
                ActiveCat = activeCat,
                Games = context.GameTypes.ToList(),
                Categories = context.Categories.ToList()
            };
            IQueryable<Country> query = context.Countries;
            if (activeGame != "0")
                query = query.Where(t => t.GameType.GameTypeId.ToString() == activeGame);
            if (activeCat != "0")
                query = query.Where(t => t.Category.CategoryId.ToString() == activeCat);
            model.Countries = query.ToList();
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Details(CountryViewModel model)
        {
            TempData["ActiveGame"] = model.ActiveGame;
            TempData["ActiveCat"] = model.ActiveCat;
            return RedirectToAction("Details", new { ID = model.Country.CountryId });
        }

        [HttpGet]
        public ViewResult Details(string id)
        {
            var model = new CountryViewModel {
                Country = context.Countries.Include(t => t.GameType).Include(t => t.Category).FirstOrDefault(t => t.CountryId == id),
                ActiveGame = TempData.Peek("ActiveGame").ToString(),
                ActiveCat = TempData.Peek("ActiveCat").ToString()
            };
            return View(model);
        }
    }
}