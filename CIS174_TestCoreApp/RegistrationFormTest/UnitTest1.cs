using CIS174_TestCoreApp.Controllers;
using CIS174_TestCoreApp.Models;
using Consul;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Moq;
using System;
using System.Diagnostics.Eventing.Reader;
using Xunit;

namespace RegistrationFormTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var rep = new Mock<IRepository<RegistrationModel>>();
            var controller = new FormController(rep.Object);

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
