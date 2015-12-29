using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.VIS;

namespace VIS.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public HomeController()
        {
            data();
        }

        private ActionResult data()
        {
            VisDemos vis = new VisDemos();

            return Json(new { data=vis.GetDataCountry()});
        }

        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
