using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Forretningslogik.Controllers
{
    // den her klasse holder styr på alle beregningsklasser og komuniker immelem GUI og Foretningslogik
    public  class BeregningerController
    {
        Gaveafgift gf = new Gaveafgift();
        Kørselsfradrag kf = new Kørselsfradrag();
        Tinglysningsafgift tf = new Tinglysningsafgift();
        YdelsePåLån ypl = new YdelsePåLån();

        // vi har lavet en variable type af klassen og lave den til static så den holder styr på hvis den er bliver brugt mere end en gang
        static BeregningerController instance_=null;

        // vi laver  Constructor til private så man kan ikke intanserer klassen igennem constructor.
        private BeregningerController()
        {

        }
        // Med den her metode får vi instansen af klassen , den returner typen af klassen
        public static BeregningerController GetIntance()
        {
            // den checker hvis vores intanse variable er blevet brugt eller nej
            if (instance_ == null)
            {
                // så første gang vi laver instancen variablen har null værdi så den lave ern ny instanse som retuneres
                BeregningerController instance_ = new BeregningerController();
                return instance_;
            }
            else
                // efter den første gang vi har lavet insatncen metoden returner den samme intanse som blev dannet den første gang
                return instance_;
        }
        //her slutter singleton


        public virtual double BeregnKørselfradrag(double antalKm, int antaldage)
        {
            return kf.BeregnKørselfradrag(antalKm, antaldage);
        }
        public double BeregnGaveafgift(string person, double beløb)
        {
            return gf.BeregnGaveafgift(person, beløb);
        }
        public double BeregnTinglysningafgift(double pris)
        {
            return tf.BeregnTinglysningafgift(pris);
        }
        public double BeregnLån(double lån, double rente, int antalÅr)
        {
            return ypl.BeregnLån(lån, rente, antalÅr);
        }


        }
}
