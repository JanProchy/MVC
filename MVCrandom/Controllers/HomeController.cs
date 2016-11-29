using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCrandom.Models;     // aby byl přístupný model Generator

namespace MVCrandom.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Generator generator = new Generator();
            ViewBag.Cislo = generator.vratCislo();
            return View();
        }
    }
}