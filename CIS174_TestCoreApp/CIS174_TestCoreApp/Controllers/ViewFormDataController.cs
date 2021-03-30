using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class ViewFormDataController : Controller
    {
        public IActionResult View1(RegistrationModel model)
        {
            return View(model);
        }
    }
}