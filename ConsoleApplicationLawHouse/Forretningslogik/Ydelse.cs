using ConsoleApplicationLawHouse.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Forretningslogik
{
    public class Ydelse
    {
        IDataBase yDB = new Database.Database();
        public int id { get; set; }
        public string navn { get; set; }
        public string typePris { get; set; }

        public Ydelse()
        {

        }
        public Ydelse(int id, string navn, string typePris)
        {
            this.id = id;
            this.navn = navn;
            this.typePris = typePris;
        }

        public Ydelse(string navn, string typePris)
        {
            this.navn = navn;
            this.typePris = typePris;
        }


        public void OpretYdelse(string ydelseNavn, string prisType)
        {
            yDB.OpretYdelse(ydelseNavn, prisType);
        }

        public void SletYdelse(int ydelsNr)
        {
            yDB.SletYdelse(ydelsNr);
        }

        public void OpdaterYdelse(string ydelseNavn, string typePris, int id)
        {
            yDB.UpdateYdelse(ydelseNavn, typePris, id);
        }

        public List<Ydelse> HentYdelse()
        {
            return yDB.HentYdelse();
        }

        public void TilføjAdvokatYdelse(int advokatid, int ydelsenr)
        {
            yDB.TilføjAdvokat(advokatid, ydelsenr);
        }

        public void HentAdvokatOgYdelse(DataTable table)
        {
            yDB.HentAdvokatOgYdelse(table);
        }
        public void SletAdvokatYdelse(int medId)
        {
            yDB.SletAdvokatYdelse(medId);
        }
    }
}
