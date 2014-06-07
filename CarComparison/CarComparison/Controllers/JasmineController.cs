using System;
using System.Web.Mvc;

namespace CarComparison.Controllers
{
    public class JasmineController : Controller
    {
        public ViewResult Run()
        {
            return View("SpecRunner");
        }
    }
}
