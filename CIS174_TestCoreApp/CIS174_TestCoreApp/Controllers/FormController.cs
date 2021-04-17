using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class FormController : Controller
    {
        private IRepository<RegistrationModel> data { get; set; }
        public FormController(IRepository<RegistrationModel> ctx) => data = ctx;

        [HttpGet]
        public IActionResult Index()
        {
            return View(new RegistrationModel());
        }

        [HttpPost]
        public IActionResult Index(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                data.Insert(model);
                data.Save();
                return RedirectToAction("View1", "ViewFormData");
            } 
            else
            {
                ViewBag.FailForm = "Please enter valid data to the form.";
                return View(model);
            }
        }
    }
}