using ConsoleApplicationLawHouse.Forretningslogik.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Forretningslogik
{
    public class Kørselsfradrag
    {
        int minusKm = 24;

        double fradragPrKm = 1.90;

        public double BeregnKørselfradrag(double antalKm, int antaldage)
        {
            if (antalKm <= minusKm)
            {
                return 0;
            }
            else
            {
                double fradragsberettigede = (antalKm - minusKm) * fradragPrKm;
                return fradragsberettigede * antaldage;
            }
        }
    }
}
