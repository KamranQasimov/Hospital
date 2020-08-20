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
        public ActionResult Doctors()
        {
            return View();
        }

        public ActionResult Patients()
        {
            return View();
        }
        public ActionResult Appointments()
        {
            return View();
        }
        public ActionResult Schedule()
        {
            return View();
        }
        public ActionResult Departments()
        {
            return View();
        }
    }
}