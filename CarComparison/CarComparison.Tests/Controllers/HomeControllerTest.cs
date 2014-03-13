using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using CarComparison;
using CarComparison.Controllers;
using Rhino.Mocks;
using NUnit.Framework;


namespace CarComparison.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
        }

        [Test]
        public void Default_Search_Loads_As_Expected()
        {
            //HomeController controller = new HomeController();
            ////var searchResults = CarComparisonService.GetAll();
            //ViewResult result = controller.Index() as ViewResult;
            //Assert.AreEqual(searchResults.count, 1);
        }
    }
}
