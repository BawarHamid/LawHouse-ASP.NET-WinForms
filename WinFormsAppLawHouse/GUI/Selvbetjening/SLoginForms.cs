using ConsoleApplicationLawHouse.Forretningslogik;
using ConsoleApplicationLawHouse.Forretningslogik.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLawHouse.GUI.Selvbetjening
{
    public partial class SLoginForms : Form
    {
        Thread th;

        KlientController kCon;

        public SLoginForms()
        {
            kCon = KlientController.GetIntance();

            InitializeComponent();
        }

        public void StartProcess(string pdfSti)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(pdfSti)
            {
                UseShellExecute = true
            };
            p.Start();
        }

        private void OpretBtn_Click(object sender, EventArgs e)
        {
            string forNavn = FornavnTxtB.Text;
            string efterNavn = EfternavnTxtB.Text;
            string adresse = AdresseTxtB.Text;
            string sTelefonNr = TelefonTxtB.Text;
            string email = EmailTxtB.Text;

            if (forNavn.Equals("") || efterNavn.Equals("") || adresse.Equals("") || sTelefonNr.Equals("") || sTelefonNr.Any(char.IsLetter) || email.Equals(""))
            {
                MessageBox.Show("The input-string was not in correct format, try again..", "INPUT | ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int tlfNr = Convert.ToInt32(sTelefonNr);
                if (kCon.IsClientExistingA(adresse) == false || kCon.IsClientExistingNR(tlfNr) == false)
                {
                    MessageBox.Show("Du opretter nu klienten: " + forNavn + efterNavn);
                    kCon.OpretKlient(new Klient(forNavn, efterNavn, adresse, email, tlfNr));
                    MessageBox.Show("Klienten er nu oprettet.." + "\n" + "\n" + "Log på selvbetjening med fornavn og dit identifikationsnummer!", "KLIENT | SELVBETJENING", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Klienten findes allerede..", "OPRET | FEJL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LogPaaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string forNavn = KlientNavnTxtB.Text;
                int klientID = Convert.ToInt32(KlientIDTxtB.Text);

                if (kCon.KlientLogin(forNavn, klientID))
                {
                    this.Close();
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("          Klienten eksisterer ikke i LawHouses database..         ");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void opennewform(object obj)
        {
            Application.Run(new SelvbetjeningForms());
        }

        private void FUdenLoginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform1(object obj)
        {
            Application.Run(new SUdenLoginForms());
        }

        private void openHelpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilHjælpeFil\\SelvbetjeningLogin.pdf");
        }
    }
}
