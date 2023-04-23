using ConsoleApplicationLawHouse.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Forretningslogik.Controllers
{
    // den her klasse holder styr på alle Sag metoder og komuniker immelem GUI og Foretningslogik
    public class SagController
    {
        Sag s = new Sag();

        // vi har lavet en variable type af klassen og lave den til static så den holder styr på hvis den er bliver brugt mere end en gang
        static SagController instance_=null;

        // vi laver  Constructor til private så man kan ikke intanserer klassen igennem constructor.
        private SagController()
        {

        }
        // Med den her metode får vi instansen af klassen , den returner typen af klassen
        public static SagController GetIntance()
        {
            // den checker hvis vores intanse variable er blevet brugt eller nej
            if (instance_ == null)
            {
                // så første gang vi laver instancen variablen har null værdi så den lave ern ny instanse som retuneres
                SagController instance_ = new SagController();
                return instance_;
            }
            else
                // efter den første gang vi har lavet insatncen metoden returner den samme intanse som blev dannet den første gang
                return instance_;
        }
        //her slutter singleton

        public void OpretSag(string sagTitel, string dateFra, string dateTil, double totalTimer, double totalPris, int klientNr, int medId)
        {
            s.OpretSag(sagTitel, dateFra, dateTil, totalTimer, totalPris, klientNr, medId);
        }
        public void HentKlientSag(DataTable table, int klientNr)
        {
            s.HentKlientSag(table, klientNr);
        }
        public void HentSag(DataTable table)
        {
            s.HentSag(table);
        }

        public void SletSag(int sagID)
        {
            s.SletSag(sagID);
        }

        public void HentFullSag(DataTable table)
        {
            s.HentFullSag(table);
        }

        public void OpretSagDetaljer(int sagnr, int ydelsenr, double antalTimer, int korsel, double totalPris, int advokatId)
        {
            s.OpretSagDetaljer(sagnr, ydelsenr, antalTimer, korsel, totalPris,advokatId);
        }

        public void IndtastEkstraPrisogTimer(int sagId, double pris, double timer)
        {
            s.IndtastEkstraPrisogTimer(sagId, pris, timer);
        }
    }
}
