using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Componen­tModel.DataAn­notations;
using MVCrandom.Controllers;

namespace MVCrandom.Models
{
    public class Kalkulacka
    {

        [Display(Name = "1. číslo")]
        public int Cislo1 { get; set; }

        [Display(Name = "2. číslo")]
        public int Cislo2 { get; set; }

        [Display(Name = "Výsledek")]
        public double Vysledek { get; set; }

        public string Operace { get; set; }

        public List<SelectListItem> MozneOperace { get; set; }
        

        public Kalkulacka()
        {
            MozneOperace = new List<SelectListItem>();  //list s jednotlivýma operacema na pocitani
            MozneOperace.Add(new SelectListItem { Text = "Sčítání", Value = "+", Selected = true });
            MozneOperace.Add(new SelectListItem { Text = "Odečítání", Value = "-" });
            MozneOperace.Add(new SelectListItem { Text = "Násobení", Value = "*" });
            MozneOperace.Add(new SelectListItem { Text = "Dělení", Value = "/" });
        }

        public void Vypocitej()
        {
            switch(Operace)
            {
                case "+":
                    Vysledek = Cislo1 + Cislo2;
                    break;
                case "-":
                    Vysledek = Cislo1 - Cislo2;
                    break;
                case "*":
                    Vysledek = Cislo1 * Cislo2;
                    break;
                case "/":
                    Vysledek = Cislo1 / Cislo2;
                    break;                   
            }
        }
    }
}