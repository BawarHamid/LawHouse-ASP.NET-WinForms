using ConsoleApplicationLawHouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Forretningslogik
{
    public class Klient
    {
        IDataBase kDB = new Database.Database();
        public int klientID { get; private set; }
        public string forNavn { get; private set; }
        public string efterNavn { get; private set; }
        public string adresse { get; private set; }
        public string email { get; private set; }
        public int telefonNr { get; private set; }
        
        public Klient()
        {

        }

        public Klient(int klientID, string forNavn, string efterNavn, string adresse, string email, int telefonNr)
        {
            this.klientID = klientID;
            this.forNavn = forNavn;
            this.efterNavn = efterNavn;
            this.adresse = adresse;
            this.email = email;
            this.telefonNr = telefonNr;
        }

        public Klient(string forNavn, string efterNavn, string adresse, string email, int telefonNr)
        {
            this.forNavn = forNavn;
            this.efterNavn = efterNavn;
            this.adresse = adresse;
            this.email = email;
            this.telefonNr = telefonNr;
        }

        public Boolean KlientLogin(string forNavn, int klientID)
        {
            return kDB.KlientLogInd(forNavn, klientID);
        }

        public void OpretKlient(Klient klient)
        {
            kDB.OpretKlient(klient);
        }

        public List<Klient> HentKlient()
        {
            return kDB.HentKlient();
        }

        public void OpdaterKlient(string forNavn, string efterNavn, string adresse, string email, int telefonNr, int klientID)
        {
            kDB.OpdaterKlient(forNavn, efterNavn, adresse, email, telefonNr, klientID);
        }

        public void SletKlient(int klientID)
        {
            kDB.SletKlient(klientID);
        }

        public bool IsClientExistingA(string adresse)
        {
            return kDB.IsClientAlreadyCreatedA(adresse);
        }
        public bool IsClientExistingNR(int telefonNr)
        {
            return kDB.IsClientAlreadyCreatedNR(telefonNr);
        }
    }
}
