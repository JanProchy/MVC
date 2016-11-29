using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCrandom.Models;

namespace MVCrandom.Controllers
{
    public class KalkulackaController : Controller
    {
        // GET: Kalkulacka
        public ActionResult Index()
        {
            Kalkulacka kalkulacka = new Kalkulacka();
            return View(kalkulacka);
        }

        [HttpPost]
        public ActionResult Index(Kalkulacka kalkulacka)
        {
            if (ModelState.IsValid)
            {
                kalkulacka.Vypocitej();
            }

            return View(kalkulacka);
        }
    }
}