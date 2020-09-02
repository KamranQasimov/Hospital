using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using Hospital.Data;

namespace Hospital.Controllers
{
    public class DoctorsController : Controller
    {
        private HospitalDbContext db = new HospitalDbContext();

        // GET: Doctors
        public ActionResult Index()
        {
            var doctors = db.Doctors.Include(d => d.Employee).Include(d => d.Schedule);
            return View(doctors.ToList());
        }

        // GET: Doctors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // GET: Doctors/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeId = new SelectList(db.Employees, "Id", "Name");
            ViewBag.Id = new SelectList(db.Schedules, "Id", "Message");
            return View();
        }

        // POST: Doctors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PinCode,Address,Avatar,Country,City,BirthDate,JopPosition,ShortBiography,ScheduleId,EmployeeId")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Doctors.Add(doctor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeId = new SelectList(db.Employees, "Id", "Name", doctor.EmployeeId);
            ViewBag.Id = new SelectList(db.Schedules, "Id", "Message", doctor.Id);
            return View(doctor);
        }

        // GET: Doctors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeId = new SelectList(db.Employees, "Id", "Name", doctor.EmployeeId);
            ViewBag.Id = new SelectList(db.Schedules, "Id", "Message", doctor.Id);
            return View(doctor);
        }

        // POST: Doctors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PinCode,Address,Avatar,Country,City,BirthDate,JopPosition,ShortBiography,ScheduleId,EmployeeId")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeId = new SelectList(db.Employees, "Id", "Name", doctor.EmployeeId);
            ViewBag.Id = new SelectList(db.Schedules, "Id", "Message", doctor.Id);
            return View(doctor);
        }

        // GET: Doctors/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var model = db.Doctors.Where(x => x.Id == id).FirstOrDefault();
            if (model != null)
            {
                db.Doctors.Remove(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return new HttpNotFoundResult();
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Doctor doctor = db.Doctors.Find(id);
            //if (doctor == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(doctor);
        }

        // POST: Doctors/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Doctor doctor = db.Doctors.Find(id);
        //    db.Doctors.Remove(doctor);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
