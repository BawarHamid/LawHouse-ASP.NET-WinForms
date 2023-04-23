using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Forretningslogik
{
   public  class YdelsePåLån
    {
        public double BeregnLån(double lån, double rente, int antalÅr)
        {
            double klarer = rente / 100;
            return (klarer * lån) / (1 - Math.Pow(1 + klarer, antalÅr * -1));
        }
    }
}
