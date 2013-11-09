using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCarpetsAtHome.Models;

namespace MyCarpetsAtHome.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Carpets()
        {
            var carpets = Product.GetAllCarpets();
            return View("Carpets/Index", carpets);
        }

        public string[] Get()
        {
            return new string[]
        {
             "Hello",
             "World"
        };
        }

    }
}
