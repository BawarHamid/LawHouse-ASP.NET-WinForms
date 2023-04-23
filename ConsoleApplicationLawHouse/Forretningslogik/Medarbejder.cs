using ConsoleApplicationLawHouse.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Forretningslogik
{
    public class Medarbejder
    {
        IDataBase mDB = new Database.Database();
        public int medarbID { get; set; }
        public string forNavn { get; set; }
        public string efterNavn { get; set; }
        public string email { get; set; }
        public int telefonNr { get; set; }
        public string billede { get; set; }
        public string stillingsType { get; set; }
        public string efterUdd { get; set; }

        public Medarbejder()
        {

        }

        //Til at hente medarbejder til UI (alle informationer).
        public Medarbejder(int medarbID, string forNavn, string efterNavn, string email, int telefonNr, string billede, string stillingsType, string efterUdd)
        {
            this.medarbID = medarbID;
            this.forNavn = forNavn;
            this.efterNavn = efterNavn;
            this.email = email;
            this.telefonNr = telefonNr;
            this.billede = billede;
            this.stillingsType = stillingsType;
            this.efterUdd = efterUdd;
        }

        //hent til task - mangler efterudd
        public Medarbejder(string forNavn, string efterNavn, string email, int telefonNr, string billede, string stillingsType)
        {
            this.forNavn = forNavn;
            this.efterNavn = efterNavn;
            this.email = email;
            this.telefonNr = telefonNr;
            this.billede = billede;
            this.stillingsType = stillingsType;
        }

        //til oprettelse af medarbejder i UI
        public Medarbejder(string forNavn, string efterNavn, string email, int telefonNr, string billede, string stillingsType, string efterUdd)
        {
            this.forNavn = forNavn;
            this.efterNavn = efterNavn;
            this.email = email;
            this.telefonNr = telefonNr;
            this.billede = billede;
            this.stillingsType = stillingsType;
            this.efterUdd = efterUdd;
        }

        //constructor til hent.
        public Medarbejder(int medarbID, string forNavn, string efterNavn, string email, int telefonNr)
        {
            this.medarbID = medarbID;
            this.forNavn = forNavn;
            this.efterNavn = efterNavn;
            this.email = email;
            this.telefonNr = this.telefonNr;
        }

      
        public Boolean MedarbejderLogin(string forNavn, int medarbID)
        {
            return mDB.MedarbejderLogInd(forNavn, medarbID);
        }

        public List<Medarbejder> ShowEmployeesTask()
        {
            return mDB.ShowEmployeesTask();
        }

        public void OpretMedarbejder(Medarbejder medarbejder)
        {
            mDB.OpretMedarbejder(medarbejder);
        }

        public List<Medarbejder> HentMedarbejder()
        {
            return mDB.HentMedarbejder();
        }

        public void OpdaterMedarbejder(string forNavn, string efterNavn, string email, int telefonNr, int medarbID)
        {
            mDB.OpdaterMedarbejder(forNavn, efterNavn, email, telefonNr, medarbID);
        }

        public void SletMedarbejder(int medarbID)
        {
            mDB.SletMedarbejder(medarbID);
        }

        public bool IsEmployeeExistingE(string email)
        {
            return mDB.IsEmployeeAlreadyCreatedE(email);
        }

        public bool IsEmployeeExistingT(int telefonNr)
        {
            return mDB.IsEmployeeAlreadyCreatedT(telefonNr);
        }

        public List<Medarbejder> SoegMedarbejer(string forNavn)
        {
            return mDB.SogMedarbejder(forNavn);
        }
        public void HentAdvokat(DataTable table)
        {
            mDB.HentAdvokat(table);
        }
        }
}
