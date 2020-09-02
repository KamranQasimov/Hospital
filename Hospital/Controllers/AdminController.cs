using Hospital.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Hospital.Controllers
{
    public class AdminController : Controller
    {
        private readonly HospitalDbContext _hospitalDbContext;
        public AdminController()
        {
            _hospitalDbContext = new HospitalDbContext();
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}