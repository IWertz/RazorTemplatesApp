using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentView(StudentList studentList, int id)
        {
            var students = studentList.setList();
            ViewBag.AccessLevel = id;
            return View(students);
        }
    }
}