using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoMarket.Controllers
{
    public class HomeController : Controller
    {
        //Index action method
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        } 
        public ActionResult Car()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
