using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Garage2._0.DataAccessLayer;
using Garage2._0.Models;

namespace Garage2._0.Controllers
{
    public class GarageController : Controller
    {
        private GarageContext db = new GarageContext();

        // GET: Garage
        public ActionResult Index(string searchString)
        {
            var garage =
                db.Garage
                .Where(r => searchString == null || r.RegNr.StartsWith(searchString));

            return View(garage);
        }

        // GET: Garage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Garage garage = db.Garage.Find(id);
            if (garage == null)
            {
                return HttpNotFound();
            }
            return View(garage);
        }

        // GET: Garage/Create
        public ActionResult Park()
        {
            return View();
        }

        // POST: Garage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Park([Bind(Include = "Id,RegNr,Vehicle,Colour,NbrOfWheels,Tid")] Garage garage)
        {
            if (ModelState.IsValid)
            {
                garage.Tid = DateTime.Now;
                db.Garage.Add(garage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(garage);
        }


        // GET: Garage/Delete/5
        public ActionResult CheckOut(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Garage garage = db.Garage.Find(id);
            if (garage == null)
            {
                return HttpNotFound();
            }
            return View(garage);
        }

        // POST: Garage/Delete/5
        [HttpPost, ActionName("CheckOut")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Garage garage = db.Garage.Find(id);
            db.Garage.Remove(garage);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
