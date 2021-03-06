﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Garage2._0.DataAccessLayer;
using Garage2._0.Models;
using Garage2._0.Utility;

namespace Garage2._0.Controllers
{
    public class GarageController : Controller
    {
        private GarageContext db = new GarageContext();

        string totTime(TimeSpan t)
        {
            return UtilityTime.TimeFix(t);
        }

        // GET: Garage
        public ActionResult Index(string searchString)
        {
            var garage =
                db.Garage
                .Where(r => searchString == null || r.RegNr.StartsWith(searchString));

            return View(garage);
        }

        // GET: Garage/Details/id
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
            ViewBag.ParkTime = totTime(DateTime.Now - garage.Tid);
            return View(garage);
        }

        //GET: Garage/Statistics
        public ActionResult Statistics(Garage g)
        {
            
            var garage = db.Garage;
            var totP = Convert.ToInt32(DateTime.Now - g.Tid) * 10;
            
            var vmStats = new StatisticsViewModel() { vehicles = garage, NbrOfWheels = garage.Sum(item => item.NbrOfWheels), Price = totP };
            return View("Statistics",vmStats);
        }

        // GET: Garage/Park
        public ActionResult Park()
        {
            return View();
        }

        // POST: Garage/Park
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Park([Bind(Include = "Id,RegNr,Vehicle,Colour,NbrOfWheels,Tid")] Garage garage)
        {
            if (ModelState.IsValid)
            {
                garage.Tid = DateTime.Now;
                db.Garage.Add(garage);
                db.SaveChanges();
                TempData["park"] = "You have successfully parked";
                return RedirectToAction("Index");
            }
            return View(garage);
        }


        // GET: Garage/CkeckOut/id
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

        // POST: Garage/CheckOut/id
        [HttpPost, ActionName("CheckOut")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Garage garage = db.Garage.Find(id);
            var p = Convert.ToInt32((DateTime.Now - garage.Tid).TotalHours) * 10;
            var vmKvitto = new KvittoViewModel() { RegNum = garage.RegNr, vehicle = garage.Vehicle, ParkTime = garage.Tid, Price = p < 10 ? 10: p, totParkTime = UtilityTime.TimeFix(DateTime.Now - garage.Tid), CheckOutTime = DateTime.Now.ToString() };
            db.Garage.Remove(garage);
            db.SaveChanges();
            return View("Kvitto", vmKvitto);
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
