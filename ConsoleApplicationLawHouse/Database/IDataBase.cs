using ConsoleApplicationLawHouse.Forretningslogik;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Database
{
    interface IDataBase
    {
        // den her interface kommuniker mellem forretningslogik og persistanse lag
        string GetConnectionString();
        //Klient 
        public bool KlientLogInd(string navn, int id);

        public void OpretKlient(Klient klient);

        public List<Klient> HentKlient();


        public void OpdaterKlient(string forNavn, string efterNavn, string adresse, string email, int tlfNr, int id);//Metoden her giver mulighed for at ændre en klient ud fra medarbID.


        public void SletKlient(int id);//Metoden her giver mulighed for at slette en klient ud fra medarbID.


        public bool IsClientAlreadyCreatedA(string adresse);//Metode for ikke at kunne oprette klienten 2 gange


        public bool IsClientAlreadyCreatedNR(int tlfNr);//Metode for ikke at kunne oprette klienten 2 gange


        //Medarbejder 
        public Boolean MedarbejderLogInd(string navn, int id);


        public List<Medarbejder> ShowEmployeesTask();

        public void HentAdvokat(DataTable table);

        public void OpretMedarbejder(Medarbejder medarb);


        //Søge efter medarbejder på deres medarbID metode.
        public List<Medarbejder> HentMedarbejder();


        public void OpdaterMedarbejder(string navn, string efterNavn, string email, int tlfNr, int id);//Metoden her giver mulighed for at ændre en klient ud fra medarbID.


        public void SletMedarbejder(int id);//Metoden her giver mulighed for at slette en klient ud fra medarbID.


        public bool IsEmployeeAlreadyCreatedE(string email);


        public bool IsEmployeeAlreadyCreatedT(int tlf);


        public List<Medarbejder> SogMedarbejder(string navn);


        //Sag
        public void OpretSag(string sagTitel, string dateFra, string dateTil, double totalTimer, double totalPris, int klientNr, int medId);

        public void SletSag(int sagID);

        public void IndtastEkstraPrisogTimer(int sagId, double pris, double timer);

        public void HentKlientSag(DataTable table, int klientNr);


        public void ShowSelectedYdelse(DataTable table, Object value);

        public void HentSag(DataTable table);


        public void OpretSagDetaljer(int sagnr, int ydelsenr, double antalTimer, int korsel, double totalPris,int advokatId);


        public void HentFullSager(DataTable table);



        //Ydelser 
        public void OpretYdelse(string ydelseNavn, string typePris);


        public List<Ydelse> HentYdelse();

        public void HentAdvokatOgYdelse(DataTable table);

        public void SletYdelse(int ydelseNr);


        public void UpdateYdelse(string ydelsNavn, string typePris, int id);


        public void TilføjAdvokat(int advokatId, int ydelseNr);


        public void SletAdvokatYdelse(int medId);
       

    }
}
