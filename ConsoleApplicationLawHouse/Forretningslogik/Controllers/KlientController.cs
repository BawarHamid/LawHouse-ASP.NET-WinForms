using ConsoleApplicationLawHouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Forretningslogik.Controllers
{
    // den her klasse holder styr på alle klient metoder og komuniker immelem GUI og Foretningslogik
    public class KlientController
    {
        Klient k = new Klient();

        // vi har lavet en variable type af klassen og lave den til static så den holder styr på hvis den er bliver brugt mere end en gang
        static KlientController instance_=null;

        // vi laver  Constructor til private så man kan ikke intanserer klassen igennem constructor.
        private KlientController()
        {

        }
        // Med den her metode får vi instansen af klassen , den returner typen af klassen
        public static KlientController GetIntance()
        {
            // den checker hvis vores intanse variable er blevet brugt eller nej
            if (instance_ == null)
            {
                // så første gang vi laver instancen variablen har null værdi så den lave ern ny instanse som retuneres
                KlientController instance_ = new KlientController();
                return instance_;
            }
            else
                // efter den første gang vi har lavet insatncen metoden returner den samme intanse som blev dannet den første gang
                return instance_;
        }
        //her slutter singleton

        public Boolean KlientLogin(string forNavn, int klientID)
        {
            return k.KlientLogin(forNavn, klientID);
        }

        public void OpretKlient(Klient klient)
        {
            k.OpretKlient(klient);
        }

        public List<Klient> HentKlient()
        {
            return k.HentKlient();
        }

        public void OpdaterKlient(string forNavn, string efterNavn, string adresse, string email, int telefonNr, int klientNr)
        {
            k.OpdaterKlient(forNavn, efterNavn, adresse, email, telefonNr, klientNr);
        }

        public void SletKlient(int klientNr)
        {
            k.SletKlient(klientNr);
        }

        public bool IsClientExistingA(string adresse)
        {
            return k.IsClientExistingA(adresse);
        }
        public bool IsClientExistingNR(int telefonNr)
        {
            return k.IsClientExistingNR(telefonNr);
        }
    }
}
