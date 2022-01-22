using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultDemo.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        //public ViewResult Index()
        //{
        //    return View("SecondView");
        //}

        //public PartialViewResult Index()
        //{
        //    return PartialView("SecondView");
        //}

        //public ContentResult Index()
        //{
        //    return Content("<h3>Zain Ul Hassan </h3>");
        //}
        //public ContentResult Index()
        //{
        //    return Content("<h3>Zain Ul Hassan</h3>", "text/html");
        //}
        //public ContentResult Index()
        //{
        //    return Content("<script> alert('Hi! I am Zain Ul Hassan') </script>");
        //}


        //public EmptyResult Index()
        //{
        //    return new EmptyResult();
        //}

        //public ActionResult Index()
        //{
        //    return null;
        //}

        //public FileResult Index()
        //{
        //    return File("~/Files/DemoFile.txt", "text/plain");
        //}

        //public FileResult Index()
        //{
        //    return File(Url.Content("~/Files/DemoFile.txt"), "text/plain","Demo1.txt");
        //}

        //public ActionResult Index()
        //{
        //    ViewBag.Message = "Your application description page.";
        //    return Json(new { Name = "veeru", age = 23 }, JsonRequestBehavior.AllowGet);
        //}

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

        public JavaScriptResult JavaScriptDemo()
        {
            return JavaScript("alert('Zain Ul hassan')");
        }

        public RedirectResult RedirectDemo()
        {
            return Redirect("https://cognine.com/");
        }

        public RedirectToRouteResult RedirectToRouteResultDemo()
        {
            return RedirectToRoute(new { Controller = "Home", action = "RedirectDemo" });
        }
    }
}