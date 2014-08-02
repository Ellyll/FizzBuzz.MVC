using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using NUnit.Framework;
using FizzBuzz.Web.Controllers;
using FizzBuzz.Core.Services;

namespace FizzBuzz.Web.Tests.Controller
{
    [TestFixture]
    public class HomeControllerTests
    {
        private class DummyFizzBuzzService : IFizzBuzzService
        {
            public string Check(int number) { return "FizzBuzzDummyResult"; }
        }

        [Test]
        public void CanCreate()
        {
            var controller = new HomeController();
            Assert.IsNotNull(controller);
        }

        [Test]
        public void CanCreateWithFizzBuzzService()
        {
            var service = new DummyFizzBuzzService();
            var controller = new HomeController(service);
            Assert.IsNotNull(controller);
        }

        [Test]
        public void CheckReturnsCorrectView()
        {
            var service = new DummyFizzBuzzService();
            var controller = new HomeController(service);

            var result = (ViewResult)controller.Index();

            Assert.AreEqual("Index", result.ViewName);
        }

        //TODO: Check other stuff (see links below)
        // http://stackoverflow.com/questions/8818207/how-should-one-unit-test-a-net-mvc-controller
        // http://www.asp.net/mvc/tutorials/older-versions/contact-manager/iteration-5-create-unit-tests-cs
    }
}
