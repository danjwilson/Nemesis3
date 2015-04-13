using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nemesis.Site.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Welcome()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Welcome(string SearchByPostcodeDistrict)
        {
            return RedirectToAction("List", "Store", new { PostcodeDistrict = SearchByPostcodeDistrict });
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}