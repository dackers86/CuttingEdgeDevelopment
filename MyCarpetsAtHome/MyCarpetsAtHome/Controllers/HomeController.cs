using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCarpetsAtHome.Code;
using MyCarpetsAtHome.Models;

namespace MyCarpetsAtHome.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Payment.CreateRequest();

            SessionHelper.InitialiseLookups();

            return View();
        }
    }
}
