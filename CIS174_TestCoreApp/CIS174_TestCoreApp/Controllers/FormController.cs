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
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("View1", "ViewFormData", model);
            } 
            else
            {
                ViewBag.FailForm = "Please enter valid data to the form.";
                return View(model);
            }
        }
    }
}