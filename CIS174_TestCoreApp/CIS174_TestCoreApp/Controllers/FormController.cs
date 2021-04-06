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
        private RegistrationModelContext context;

        public FormController(RegistrationModelContext ctx)
        {
            context = ctx;
        }

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
                context.Tickets.Add(model);
                context.SaveChanges();
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