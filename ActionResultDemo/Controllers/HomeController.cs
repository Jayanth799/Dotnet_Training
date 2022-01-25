using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ActionResultDemo.Controllers
{
    public class HomeController : Controller
    {

        //Content Returning Results 


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewResultsDemo()
        {
            return View("SecondView");
        }

        public ActionResult PartialVIewResultsDemo()
        {
            return PartialView("SecondView");
        }

        public ActionResult ContentDemo()
        {
            return Content("<h3>Zain Ul Hassan </h3>");
        }

        public ActionResult ContentWithTypeDemo()
        {
            return Content("<h3>Zain Ul Hassan</h3>", "text/html");
        }

        public ActionResult ScriptAsContent()
        {
            return Content("<script> alert('Hi! I am Zain Ul Hassan') </script>");
        }

        public ActionResult EmptyResultDemo()
        {
            return new EmptyResult();
        }

        public ActionResult EmptyDemo()
        {
            return null;
        }

        public ActionResult FileContentDemo()
        {
            return File("~/Files/DemoFile.txt", "text/plain");
        }

        public ActionResult FileDownloadDemo()
        {
            return File(Url.Content("~/Files/DemoFile.txt"), "text/plain", "Demo1.txt");
        }

        public ActionResult JsonResultsDemo()
        {
            ViewBag.Message = "Your application description page.";
            return Json(new { Name = "veeru", age = 23 }, JsonRequestBehavior.AllowGet);
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

        public ActionResult JavaScriptDemo()
        {
            return JavaScript("alert('Zain Ul hassan')");
        }

        //Redirection Results
        public ActionResult RedirectDemo()
        {
            return Redirect("https://cognine.com/");
        }

        public ActionResult RedirectToRouteResultDemo()
        {
            return RedirectToRoute(new { Controller = "Home", action = "HttpStatusCodeResultDemo" });
        }


        //Status Result

        //HttpStatusCodeResult

        public ActionResult HttpStatusCodeResultDemo()
        {
            return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
        }

        //HttpUnauthorizedResult

        public ActionResult HttpUnauthorizedResultDemo()
        {
            return new HttpStatusCodeResult(HttpStatusCode.Unauthorized, "sorry! you don't have access.");
        }

        //HttpNotFoundResult
        public ActionResult HttpNotFoundResultDemo()
        {
            return new HttpUnauthorizedResult("sorry! you don't have access.");
        }
    }
}