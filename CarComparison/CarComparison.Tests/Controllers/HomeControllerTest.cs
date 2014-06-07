using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using CarComparison;
using CarComparison.Controllers;
using Rhino.Mocks;
using NUnit.Framework;
using CarCompairsonAPI.Repository;
using CarCompairsonAPI.Controllers;
using CarCompairsonAPI.Models;


namespace CarComparison.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        private ISearchController _mockAPISearchController;

        [SetUp]
        public void Setup()
        {
            _mockAPISearchController = MockRepository.GenerateMock<ISearchController>();
        }

        [Test]
        public void Index()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;

        }
    }
}
