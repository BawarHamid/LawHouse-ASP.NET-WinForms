using ConsoleApplicationLawHouse.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Forretningslogik
{
    public class Sag
    {
        IDataBase sDB = new Database.Database();
        public int ID { get; set; }
        public string titel { get; set; }
        public double antalTimer { get; set; }
        public DateTime startsDato { get; set; }
        public DateTime slutDato { get; set; }
        public double totalPris { get; set; }

        
       

        public Sag(int sagId)
        {
            this.ID = sagId;
        }
        public Sag()
        {

        }

        public void OpretSag(string sagTitel, string dateFra, string dateTil, double totalTimer, double totalPris, int klientNr, int medId)
        {
            sDB.OpretSag(sagTitel, dateFra, dateTil, totalTimer, totalPris, klientNr, medId);
        }
        public void HentKlientSag(DataTable table, int klientNr)
        {
            sDB.HentKlientSag(table, klientNr);
        }
        public void HentSag(DataTable table)
        {
            sDB.HentSag(table);
        }

        public void SletSag(int sagID)
        {
            sDB.SletSag(sagID);
        }

        public void HentFullSag(DataTable table)
        {
            sDB.HentFullSager(table);
        }

        public void OpretSagDetaljer(int sagnr, int ydelsenr, double antalTimer, int korsel, double totalPris,int advokatId)
        {
            sDB.OpretSagDetaljer(sagnr, ydelsenr, antalTimer, korsel, totalPris,advokatId);
        }

        public void IndtastEkstraPrisogTimer(int sagId, double pris, double timer)
        {
            sDB.IndtastEkstraPrisogTimer(sagId, pris, timer);
        }
    }
}
