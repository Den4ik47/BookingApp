using BookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookingApp.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Get_Date()
        {
            return View();
        }
        [HttpPost]
        public double Get_Date(double x) {
            return Math.Sqrt(x);
        }
    }
}