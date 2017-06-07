using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Garage2._0.DataAccessLayer;
using Garage2._0.Models;

namespace Garage2._0.Controllers
{
    public class HomeController : Controller
    {
        private GarageContext db = new GarageContext();
        public ActionResult Index()
        {
            return View(db.Garage);
        }

    //public ActionResult About()
    //{
    //    //ViewBag.Message = "Your application description page.";

    //    return View();
    //}

    //public ActionResult Contact()
    //{
    //    ViewBag.Message = "Your contact page.";

    //    return View();
    //}
    }
}