using ConsoleApplicationLawHouse.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Forretningslogik.Controllers
{
    // den her klasse holder styr på alle ydelse metoder og komuniker immelem GUI og Foretningslogik
    public class YdelseController
    {
        Ydelse y = new Ydelse();

        // vi har lavet en variable type af klassen og lave den til static så den holder styr på hvis den er bliver brugt mere end en gang
        static YdelseController instance_ = null;

        // vi laver  Constructor til private så man kan ikke intanserer klassen igennem constructor.
        private YdelseController()
        {

        }
        // Med den her metode får vi instansen af klassen , den returner typen af klassen
        public static YdelseController GetIntance()
        {
            // den checker hvis vores intanse variable er blevet brugt eller nej
            if (instance_ == null)
            {
                // så første gang vi laver instancen variablen har null værdi så den lave ern ny instanse som retuneres
                YdelseController instance_ = new YdelseController();
                return instance_;
            }
            else
                // efter den første gang vi har lavet insatncen metoden returner den samme intanse som blev dannet den første gang
                return instance_;
        }
        //her slutter singleton

        public void OpretYdelse(string ydelseNavn, string prisType)
        {
            y.OpretYdelse(ydelseNavn, prisType);
        }

        public void SletYdelse(int ydelsNr)
        {
            y.SletYdelse(ydelsNr);
        }

        public void OpdaterYdelse(string ydelseNavn, string typePris, int id)
        {
            y.OpdaterYdelse(ydelseNavn, typePris, id);
        }

        public List<Ydelse> HentYdelse()
        {
            return y.HentYdelse();
        }

        public void TilføjAdvokatYdelse(int advokatid, int ydelsenr)
        {
            y.TilføjAdvokatYdelse(advokatid, ydelsenr);
        }

        //public void HentYdelser()
        //{
        //    yDB.HentYdelse();
        //}

        public void HentAdvokatOgYdelse(DataTable table)
        {
            y.HentAdvokatOgYdelse(table);
        }

        public void SletAdvokatYdelse(int medId)
        {
            y.SletAdvokatYdelse(medId);
        }
    }
}
