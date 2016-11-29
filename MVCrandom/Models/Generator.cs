using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCrandom;

namespace MVCrandom.Models
{
    public class Generator
    {
        private Random random = new Random();

        public int vratCislo()
        {
            return random.Next(100);        // random číslo 0 - 100
        }
    }
}