using ConsoleApplicationLawHouse.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Forretningslogik.Controllers
{
    // den her klasse holder styr på alle medarbejder metoder og komuniker immelem GUI og Foretningslogik
    public class MedarbejderController
    {
        Medarbejder m = new Medarbejder();
        // vi har lavet en variable type af klassen og lave den til static så den holder styr på hvis den er bliver brugt mere end en gang
        static MedarbejderController instance_=null;

        // vi laver  Constructor til private så man kan ikke intanserer klassen igennem constructor.
        private MedarbejderController()
        {

        }
        // Med den her metode får vi instansen af klassen , den returner typen af klassen
        public static MedarbejderController GetIntance()
        {
            // den checker hvis vores intanse variable er blevet brugt eller nej
            if (instance_ == null)
            {
                // så første gang vi laver instancen variablen har null værdi så den lave ern ny instanse som retuneres
                MedarbejderController instance_ = new MedarbejderController();
                return instance_;
            }
            else
                // efter den første gang vi har lavet insatncen metoden returner den samme intanse som blev dannet den første gang
                return instance_;
        }
        //her slutter singleton

        public Boolean MedarbejderLogin(string navn, int medarbejderID)
        {
            return m.MedarbejderLogin(navn, medarbejderID);
        }

        public List<Medarbejder> ShowEmployeesTask()
        {
            return m.ShowEmployeesTask();
        }

        public void OpretMedarbejder(Medarbejder medarb)
        {
            m.OpretMedarbejder(medarb);
        }

        public List<Medarbejder> HentMedarbejder()
        {
            return m.HentMedarbejder();
        }

        public void OpdaterMedarbejder(string medNavn, string medefterNavn, string email, int tlfNr, int medarbNr)
        {
            m.OpdaterMedarbejder(medNavn, medefterNavn, email, tlfNr, medarbNr);
        }

        public void SletMedarbejder(int medarbNr)
        {
            m.SletMedarbejder(medarbNr);
        }

        public bool IsEmployeeExistingE(string email)
        {
            return m.IsEmployeeExistingE(email);
        }

        public bool IsEmployeeExistingT(int tlf)
        {
            return m.IsEmployeeExistingT(tlf);
        }

        public List<Medarbejder> SoegMedarbejer(string medarbNavn)
        {
            return m.SoegMedarbejer(medarbNavn);
        }

        public void HentAdvokat(DataTable table)
        {
            m.HentAdvokat(table);
        }
    }
}
