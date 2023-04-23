using ConsoleApplicationLawHouse.Forretningslogik;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLawHouse.Database
{
    public class Database : IDataBase 
    {
        //her får vi connection til vores database
        public string GetConnectionString()
        {
            return "Server=den1.mssql7.gear.host; Database=lawhousevejle; User Id=lawhousevejle; Password=!LawHouse2021!";
        }


        //Klient  metoder

        // den her metoden checker hvis in klient findes i databasen med det forNavn og medarbID for at log ind
        public bool KlientLogInd(string forNavn, int klientID)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Klient WHERE ForNavn = ('{forNavn}') AND KlientID = ({klientID})", conn);

             // SqlDatareader klasse bruges for at læs data fra en sqldatabase
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();
            Boolean Klienter = dataReader.HasRows;

            conn.Close();
            return Klienter;
        }

        // den her metode opretter klienter med alle de nødvendige informationer
        public void OpretKlient(Klient klient)
        {
            
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand INSERTCOMMAND = new SqlCommand
                ($"INSERT INTO Klient (ForNavn, EfterNavn, Adresse, Email, TelefonNr) VALUES " +
                $"('{klient.forNavn}', '{klient.efterNavn}', '{klient.adresse}','{klient.email}', {klient.telefonNr})", conn);
            INSERTCOMMAND.ExecuteNonQuery();

            conn.Close();
        }

        // metoden henter en klient som liste af klienter
        public List<Klient> HentKlient()
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            List<Klient> klientList = new List<Klient>(); //Vi laver en liste, som indeholder alle klienterne

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Klient", conn);
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    int klientID = dataReader.GetInt32(0);
                    string forNavn = dataReader.GetString(1);
                    string efterNavn = dataReader.GetString(2);
                    string adresse = dataReader.GetString(3);
                    string email = dataReader.GetString(4);
                    int telefonNr = dataReader.GetInt32(5);

                    Klient klient = new Klient(klientID, forNavn, efterNavn, adresse, email, telefonNr);
                    klientList.Add(klient);
                }
            }
            conn.Close();
            return klientList;
        }

        //Metoden her giver mulighed for at ændre en klient ud fra medarbID.
        public void OpdaterKlient(string forNavn, string efterNavn, string adresse, string email, int telefonNr, int klientID)
        {
            //db.GetConnection();
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand UPDATECOMMAND = new SqlCommand
                ($"UPDATE Klient SET ForNavn = ('{forNavn}'), EfterNavn = ('{efterNavn}'), Adresse = ('{adresse}')," +
                $" Email = ('{email}'), TelefonNr = ({telefonNr}) WHERE KlientID = ({klientID})", conn);
            UPDATECOMMAND.ExecuteNonQuery();
            conn.Close();
        }

        //Metoden her giver mulighed for at slette en klient ud fra medarbID.
        public void SletKlient(int klientID)
        {
            //db.GetConnection();
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand DELETECOMMAND = new SqlCommand
                ($"DELETE FROM Klient WHERE KlientID = ({klientID})", conn);
            DELETECOMMAND.ExecuteNonQuery();
            conn.Close();
        }

        //Metode for ikke at kunne oprette klienten 2 gange, den checker adresse
        public bool IsClientAlreadyCreatedA(string adresse)
        {
            //db.GetConnection();
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Klient WHERE Adresse = ('{adresse}')", conn);
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            bool resultat = false;

            while (dataReader.Read())
            {
                // den retuner true hvis der findes en medarbejder med de samme adresse
                if (dataReader.HasRows)
                {
                    resultat = true;
                }
                // og false hvis der ikke findes
                else
                {
                    resultat = false;
                }
            }
            conn.Close();
            return resultat;
        }

        //Metode for ikke at kunne oprette klienten 2 gange, den checjer telefon
        public bool IsClientAlreadyCreatedNR(int telefonNr)
        {
            //db.GetConnection();
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Klient WHERE TelefonNr = ({telefonNr})", conn);
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            bool resultat = false;

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    resultat = true;
                }
                else
                {
                    resultat = false;
                }
            }
            conn.Close();
            return resultat;
        }

        //Medarbejder  metoder

        // Metoden checker om der findes en medarbejder med en bestemt forNavn og medarbID og hvis det gør så kan medarbejderen log ind
        public Boolean MedarbejderLogInd(string forNavn, int medarbID)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Medarbejder WHERE ForNavn = ('{forNavn}') AND MedArbID = ({medarbID})", conn);

            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();
            Boolean Klienter = dataReader.HasRows;

            conn.Close();
            return Klienter;
        }

        //Metode der henter alle medarbejderne i en list til task funktionen, den bruges i personale forms
        public List<Medarbejder> ShowEmployeesTask() 
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            List<Medarbejder> medarbejderList = new List<Medarbejder>();

            SqlCommand SelectCmd = new SqlCommand($"SELECT * FROM Medarbejder", conn);
            SqlDataReader dataReader = SelectCmd.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    string forNavn = dataReader.GetString(1);
                    string efterNavn = dataReader.GetString(2);
                    string email = dataReader.GetString(3);
                    int telefonNr = dataReader.GetInt32(4);
                    string billede = dataReader.GetString(5);
                    string stillingsType = dataReader.GetString(6);
                    //string efterUdd = dataReader.GetString(6);
                    Medarbejder medarbejder = new Medarbejder(forNavn, efterNavn, email, telefonNr, billede, stillingsType);
                    medarbejderList.Add(medarbejder);
                }
            }
            conn.Close();
            return medarbejderList;
        }

        //metoden opretter en medarbejder med de nøvdendige informationer
        public void OpretMedarbejder(Medarbejder medarb)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand INSERTCOMMAND = new SqlCommand
                ($"INSERT INTO Medarbejder (ForNavn, EfterNavn, Email, TelefonNr, Billede, StillingsType, EfterUdd) VALUES " +
                $"('{medarb.forNavn}', '{medarb.efterNavn}', '{medarb.email}', {medarb.telefonNr}, '{medarb.billede}', '{medarb.stillingsType}', '{medarb.efterUdd}')", conn);

            INSERTCOMMAND.ExecuteNonQuery();
            conn.Close();
        }

        // Metoden der henter alle medarbejderne i en list til gridview.
        public List<Medarbejder> HentMedarbejder() 
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            List<Medarbejder> medarbejderList = new List<Medarbejder>();

            SqlCommand SelectCmd = new SqlCommand($"SELECT * FROM Medarbejder", conn);
            SqlDataReader dataReader = SelectCmd.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    int medarbID = dataReader.GetInt32(0);
                    string forNavn = dataReader.GetString(1);
                    string efterNavn = dataReader.GetString(2);
                    string email = dataReader.GetString(3);
                    int telefonNr = dataReader.GetInt32(4);
                    string billede = dataReader.GetString(5);
                    string stillingsType = dataReader.GetString(6);
                    string efterUdd = dataReader.GetString(7);
                    
                    Medarbejder medarbejder = new Medarbejder(medarbID, forNavn, efterNavn, email, telefonNr, billede, stillingsType, efterUdd);
                    medarbejderList.Add(medarbejder);
                }
            }
            conn.Close();
            return medarbejderList;
        }

        //Metoden her giver mulighed for at ændre en klient ud fra medarbID.
        public void OpdaterMedarbejder(string forNavn, string efterNavn, string email, int telefonNr, int medarbID)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand UPDATECOMMAND = new SqlCommand
                ($"UPDATE Medarbejder SET ForNavn = ('{forNavn}'), EfterNavn = ('{efterNavn}'), Email = ('{email}'), TelefonNr = ({telefonNr})  WHERE MedArbID = ({medarbID})", conn);
            UPDATECOMMAND.ExecuteNonQuery();
            conn.Close();
        }

        //Metoden her giver mulighed for at slette en klient ud fra medarbID.

        public void SletMedarbejder(int medarbID)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand DELETECOMMAND = new SqlCommand
                ($"DELETE FROM Medarbejder WHERE MedArbID = ({medarbID})", conn);
            DELETECOMMAND.ExecuteNonQuery();
            conn.Close();
        }

        // metoden checke hvis to medarbejder har den samme email så de kan ikke laves to medarbejder med samme info
        public bool IsEmployeeAlreadyCreatedE(string email)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Medarbejder WHERE Email = ('{email}')", conn);
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            bool resultat = false;

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    resultat = true;
                }
                else
                {
                    resultat = false;
                }
            }
            conn.Close();
            return resultat;
        }

        // metoden checke hvis to medarbejder har den samme telefon så de kan ikke laves to medarbejder med samme info
        public bool IsEmployeeAlreadyCreatedT(int telefonNr)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Medarbejder WHERE TelefonNr = ({telefonNr})", conn);
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            bool resultat = false;

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    resultat = true;
                }
                else
                {
                    resultat = false;
                }
            }
            conn.Close();
            return resultat;
        }

        // får du mulighed at søg en medarbejder fra forNavn
        public List<Medarbejder> SogMedarbejder(string forNavn)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            List<Medarbejder> medarbejderList = new List<Medarbejder>();

            SqlCommand SelectCmd = new SqlCommand($"SELECT * FROM Medarbejder WHERE ForNavn = ({forNavn})", conn);
            SqlDataReader dataReader = SelectCmd.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    int medarbID = dataReader.GetInt32(0);
                    //string forNavn = dataReader.GetString(1);
                    string efterNavn = dataReader.GetString(2);
                    string email = dataReader.GetString(3);
                    int telefonNr = dataReader.GetInt32(4);

                    Medarbejder medarbejder = new Medarbejder(medarbID, forNavn, efterNavn, email, telefonNr);
                    medarbejderList.Add(medarbejder);
                }
            }
            conn.Close();
            return medarbejderList;
        }

        //Sag metoder

        // opretter en sag med de nødvendige informationer
        public void OpretSag(string sagTitel, string dateFra, string dateTil, double totalTimer, double totalPris, int klientID, int medarbID)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand cmd = new SqlCommand($"INSERT INTO Sag (Titel, DatoFra, DatoTil, TotalTimer, TotalPris, KlientID, MedArbID) VALUES " +
                $"('{sagTitel}','{dateFra}', '{dateTil}', {totalTimer}, {totalPris}, {klientID}, {medarbID})");
            cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //henter sager som har den samme klient nummer
        public void HentKlientSag(DataTable table, int klientID)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            string klientComand = $"SELECT * FROM FullSagView WHERE KlientID = {klientID} ";
            // Sql data adapter klasse bruger en sql komando  og en database connection og kan bruges til at fylde en Data set med informationer
            SqlDataAdapter da = new SqlDataAdapter(klientComand, conn);

            // her bruger vi vores Sql data adapter og med hjælp af Fill metoden opfylder man alle info i den bestemte datatable
            da.Fill(table);
            conn.Close();
        }

       // her henter vi alle sage og fylder dem i en data table
        public void HentSag(DataTable table)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            string ydelserQuery = "SELECT * FROM SagKlientView";
            SqlDataAdapter da = new SqlDataAdapter(ydelserQuery, conn);

            da.Fill(table);
            conn.Close();

        }


        public void SletSag(int sagID)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand DELETECOMMAND = new SqlCommand
                ($"DELETE FROM Sag WHERE SagID = ({sagID})", conn);
            DELETECOMMAND.ExecuteNonQuery();
            conn.Close();
            
        }

        // her tilføje vi ydelser i sagen og andre informationer
        public void OpretSagDetaljer(int sagnr, int ydelsenr, double antalTimer, int korsel, double totalPris,int advokatId)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            SqlCommand cmd = new SqlCommand($"INSERT INTO SagYdelseMedarbejder (SagID, YdelseID, AntalTimer, korsel, pris,MedArbID) VALUES ({sagnr}, {ydelsenr}, {antalTimer}, {korsel}, {totalPris},{advokatId})");
            cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // her vises sagerne med mere detljerede informationer informationer
        public void HentFullSager(DataTable table)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            string command = "SELECT * FROM FullSagView";
            SqlDataAdapter da = new SqlDataAdapter(command, conn);

            da.Fill(table);
            conn.Close();
        }


        //metoden sætter ekstra timer og pris i sagen
        public void IndtastEkstraPrisogTimer(int sagId, double pris, double timer)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();


            SqlCommand InsertCommand = new SqlCommand
                ($"Update Sag set TotalTimer=TotalTimer+{timer}, TotalPris=TotalPris+{pris} where SagID={sagId}", conn);

            InsertCommand.ExecuteNonQuery();
            conn.Close();
        }


        //Ydelser  metoder

        // metoden opretter en ydelser med de nøvdendige informationer
        public void OpretYdelse(string ydelseNavn, string typePris)
        {

            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();


            SqlCommand SelectCmd = new SqlCommand();
            SelectCmd.CommandText = $"insert into Ydelse (Navn, TypePris) values('{ydelseNavn}','{typePris}') ";
            SelectCmd.Connection = conn;
            SelectCmd.ExecuteNonQuery();
            conn.Close();
        }

        // Her henter vi en ydelse ud fra ydelse nummer
        public void ShowSelectedYdelse(DataTable table, Object value)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            string ydelserQuery = "SELECT * FROM Ydelse WHERE YdelseID ='" + value + " '";
            SqlDataAdapter da = new SqlDataAdapter(ydelserQuery, conn);


            da.Fill(table);
            conn.Close();
        }

        // vi henter en  liste med alle ydelser
        public List<Ydelse> HentYdelse()
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            //Vi laver en liste, som indeholder alle klienterne
            List<Ydelse> ydelseList = new List<Ydelse>(); 

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Ydelse", conn);
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    int id = dataReader.GetInt32(0);
                    string navn = dataReader.GetString(1);
                    string typePris = dataReader.GetString(2);


                    Ydelse ydelse = new Ydelse(id, navn, typePris);
                    ydelseList.Add(ydelse);
                }
            }
            conn.Close();
            return ydelseList;
        }

        //slettes ydelse yd af ydelse nummer
        public void SletYdelse(int ydelseNr)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();
            SqlCommand SelectCmd = new SqlCommand();
            SelectCmd.CommandText = $"Delete from Ydelse where YdelseID = {ydelseNr} ";
            SelectCmd.Connection = conn;
            SelectCmd.ExecuteNonQuery();
            conn.Close();
        }


        // opdaterer informationer til den ønskede ydelse
        public void UpdateYdelse(string ydelsNavn, string typePris, int id)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();
            SqlCommand SelectCmd = new SqlCommand();
            SelectCmd.CommandText = $"update Ydelse set Navn = ('{ydelsNavn}'), TypePris =('{typePris}') where YdelseID = {id} ";
            SelectCmd.Connection = conn;
            SelectCmd.ExecuteNonQuery();
            conn.Close();
        }


        // den bruges til at tilkoble en advokat til en ydelse
        public void TilføjAdvokat(int advokatId, int ydelseNr)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();
            SqlCommand SelectCmd = new SqlCommand();
            SelectCmd.CommandText = $"insert into MedarbejderYdelse (MedArbID,YdelseID) values ({advokatId},{ydelseNr}) ";
            SelectCmd.Connection = conn;
            SelectCmd.ExecuteNonQuery();
            conn.Close();
        }

        // bruges ti at se hvilken Medarbejde kan lave bestemte ydelser
        public void HentAdvokatOgYdelse(DataTable table)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            string selectComand = $"Select * from AdvokatYdelseView ";
          
            SqlDataAdapter da = new SqlDataAdapter(selectComand, conn);

            // her bruger vi vores Sql data adapter og med hjælp af Fill metoden opfylder man alle info i den bestemte datatable
            da.Fill(table);
            conn.Close();

        }

        // Viser alle medarbejder der er advokater
        public void HentAdvokat(DataTable table )
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            string SelectCmd = $"select MedArbId,ForNavn,EfterNavn,Email,TelefonNr,StillingsType,EfterUdd from Medarbejder where stillingsType='Advokat' ";
            SqlDataAdapter d = new SqlDataAdapter(SelectCmd, conn);
            d.Fill(table);
            conn.Close();
        }
        
        //Sletter tillknytelsen mellem en advokat og en ydelse
        public void SletAdvokatYdelse(int AdvokatNr)
        {
           
                SqlConnection conn = new SqlConnection(GetConnectionString());
                conn.Open();
                SqlCommand deleteCmd = new SqlCommand();
                deleteCmd.CommandText = $"Delete from MedarbejderYdelse where MedArbID = {AdvokatNr} ";
                deleteCmd.Connection = conn;
                deleteCmd.ExecuteNonQuery();
                conn.Close();
            }
        }

    }

