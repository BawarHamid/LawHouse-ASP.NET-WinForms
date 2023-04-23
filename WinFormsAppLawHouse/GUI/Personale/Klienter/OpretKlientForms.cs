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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLawHouse.GUI.Personale.Klienter
{
    public partial class OpretKlientForms : Form
    {
        KlientController kController;

        public OpretKlientForms()
        {
            kController = KlientController.GetIntance();
            InitializeComponent();
            KlientView.DataSource = kController.HentKlient();
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

        public void UpdateList()
        {
            KlientView.DataSource = kController.HentKlient();
            navnTxtBox.Clear();
            efterNavnTxtBox.Clear();
            adresseTxtBox.Clear();
            emailTxtBox.Clear();
            tlfNrTxtBox.Clear();
        }

        private void OpretBtn_Click(object sender, EventArgs e)
        {
            string forNavn = navnTxtBox.Text;
            string efterNavn = efterNavnTxtBox.Text;
            string adresse = adresseTxtBox.Text;
            string sTelefonNr = tlfNrTxtBox.Text;
            string email = emailTxtBox.Text;

            if (forNavn.Equals("") || efterNavn.Equals("") || adresse.Equals("") || sTelefonNr.Equals("") || sTelefonNr.Any(char.IsLetter) || email.Equals(""))
            {
                MessageBox.Show("The input-string was not in correct format, try again..", "INPUT | ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int tlfNr = Convert.ToInt32(sTelefonNr);
                if (kController.IsClientExistingA(adresse) == false || kController.IsClientExistingNR(tlfNr) == false)
                {
                    MessageBox.Show("Du opretter nu klienten: " + forNavn + " " + efterNavn);
                    kController.OpretKlient(new Klient(forNavn, efterNavn, adresse, email, tlfNr));
                    MessageBox.Show("Klienten er nu oprettet.." + "\n" + "\n" +
                        "Næste gang der benyttes selvbetjening skal fornavn og klient identifikationsnummer indtastes!", "KLIENT | OPRET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateList();
                }
                else
                {
                    MessageBox.Show("Klienten findes allerede..", "OPRET | FEJL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SletBtn_Click(object sender, EventArgs e) //har stadig et problem
        {
            try
            {
                int klientID = Convert.ToInt32(KlientView.CurrentRow.Cells[0].Value);
                string forNavn = KlientView.CurrentRow.Cells[1].Value.ToString();
                string efterNavn = KlientView.CurrentRow.Cells[2].Value.ToString();

                MessageBox.Show("Du har valgt klienten: " + forNavn + " " + efterNavn + " som har identifikationsnummeret: " + klientID);
                if (MessageBox.Show("Er du sikker på at du vil slette klienten med identifikationsnummer: " + klientID + "?", "KLIENT | SLET", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    kController.SletKlient(klientID);
                    MessageBox.Show("Klienten er nu slettet..");
                    UpdateList();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void OpdatereBtn_Click(object sender, EventArgs e)
        {
            string forNavn = navnTxtBox.Text;
            string efterNavn = efterNavnTxtBox.Text;
            string adresse = adresseTxtBox.Text;
            string sTelefonNr = tlfNrTxtBox.Text;
            string email = emailTxtBox.Text;

            if (forNavn.Equals("") || efterNavn.Equals("") || adresse.Equals("") || sTelefonNr.Equals("") || sTelefonNr.Any(char.IsLetter) || email.Equals(""))
            {
                MessageBox.Show("The input-string was not in correct format, try again..", "INPUT | ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int telefonNr = Convert.ToInt32(sTelefonNr);
                if (kController.IsClientExistingA(adresse) == false || kController.IsClientExistingNR(telefonNr) == false)
                {
                    int klientID = Convert.ToInt32(KlientView.CurrentRow.Cells[0].Value);
                    MessageBox.Show("Du har valgt klienten: " + forNavn + " " + efterNavn + " som har identifikationsnummeret: " + klientID);
                    if (MessageBox.Show("Er du sikker på at du vil opdatere klienten med identifikationsnummer: " + klientID + "?", "KLIENT | OPDATER", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        kController.OpdaterKlient(forNavn, efterNavn, adresse, email, telefonNr, klientID);
                        MessageBox.Show("Du har nu opdateret den valgte klient..", "KLIENT | OPDATER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateList();
                    }
                }
                else
                {
                    MessageBox.Show("Der er et eller flere bestemte informationer som allerede tilhører en eksisterende klient.." + "\n" + "\n" + "Prøv igen med andet telefonnummer og(eller) email..", "OPDATER | FEJL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void KlientView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            navnTxtBox.Text = KlientView.CurrentRow.Cells[1].Value.ToString();
            efterNavnTxtBox.Text = KlientView.CurrentRow.Cells[2].Value.ToString();
            adresseTxtBox.Text = KlientView.CurrentRow.Cells[3].Value.ToString();
            emailTxtBox.Text = KlientView.CurrentRow.Cells[4].Value.ToString();
            tlfNrTxtBox.Text = KlientView.CurrentRow.Cells[5].Value.ToString();
        }

        private void openHelpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilHjælpeFil\\Klienter.pdf");
        }

        private void RydBtn_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void OpretKlientForms_Load(object sender, EventArgs e)
        {

        }
    }
}
