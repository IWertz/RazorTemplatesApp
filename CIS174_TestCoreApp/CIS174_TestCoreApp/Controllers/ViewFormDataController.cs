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
        private RegistrationModelContext context;

        public ViewFormDataController(RegistrationModelContext ctx)
        {
            context = ctx;
        }

        public IActionResult View1()
        {
            var tickets = context.Tickets.ToList();
            return View(tickets);
        }
    }
}