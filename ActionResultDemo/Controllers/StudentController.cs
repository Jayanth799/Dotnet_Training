using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public PartialViewResult Name()
        {
            return PartialView("_SecondView");
        }
    }
}