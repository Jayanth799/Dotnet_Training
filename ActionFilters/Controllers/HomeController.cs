using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 10)]
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
        public ActionResult ContentPage()
        {
            return Content("Cognine");
        }
        public ActionResult JsonResultsPage()
        {
            return Json(new { names = "barcode", value = "barcode"},JsonRequestBehavior.AllowGet);
        }

        public ActionResult RedirectMethod()
        {
            return RedirectToAction("Index");
        }
    }
}