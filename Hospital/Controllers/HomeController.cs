using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Doctors()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Patients()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Appointments()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Schedule()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Departments()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}