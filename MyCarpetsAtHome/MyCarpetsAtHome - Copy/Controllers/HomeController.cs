using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCarpetsAtHome.Models;

namespace MyCarpetsAtHome.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Carpets()
        {
            var carpets = Product.GetAllProducts();
            return View("Products/Carpets", carpets);
        }

    }
}
