using ConsoleApplicationLawHouse.Forretningslogik.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Forretningslogik
{
   public  class Tinglysningsafgift
    {

        double grundbeløb = 1750;
        double rente = 0.006;

        public double BeregnTinglysningafgift(double pris)
        {
            return pris * rente + grundbeløb;
        }
    }
}
