using ConsoleApplicationLawHouse.Forretningslogik.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Forretningslogik
{
   public  class Gaveafgift
    {
        double afgift = 0;
        double afgiftfritsBeløb = 0;
        double result = 0;

        public  double BeregnGaveafgift(string person, double beløb)
        {
            if (person == "Børn" || person == "Stedbørn" || person == "Børnebørn" || person == "Stedbørnebørn" || person == "Oldebørn" || person == "Stedbarns-ægtefælle" || person == "Plejebørn" || person == "Samlevende")
            {
                afgiftfritsBeløb = 68700;
                afgift = 0.15;
                result = (beløb - afgiftfritsBeløb) * afgift;
                return result;
            }
            if (person == "Ægtefælle")
            {
                return 0;
            }

            if (person == "Stedforældre " || person == "Bedsteforældre")
            {

                afgiftfritsBeløb = 68700;
                afgift = 0.3625;
                result = (beløb - afgiftfritsBeløb) * afgift;
                return result;
            }

            if (person == " Svigerbørn")
            {

                afgiftfritsBeløb = 24000;
                afgift = 0.15;
                result = (beløb - afgiftfritsBeløb) * afgift;
                return result;
            }
            else
                return 0;

        }

    }
}
