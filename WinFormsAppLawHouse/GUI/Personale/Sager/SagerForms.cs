using ConsoleApplicationLawHouse.Forretningslogik.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WinFormsAppLawHouse.GUI.Personale.Sager
{
    public partial class SagerForms : Form
    {
        SagController sController;
        YdelseController yController;

        public SagerForms()
        {
            sController = SagController.GetIntance();
            yController = YdelseController.GetIntance();
            InitializeComponent();
            ShowSagGridView();
            DataTable dt = new DataTable();
            sController.HentSag(dt);
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
            DataTable dt = new DataTable();
            sController.HentSag(dt);
            SagFormDataGritVew.DataSource = dt;
            txtboxKlientId.Clear();
            txtboxSagTitel.Clear();
            txtboxTotalTimer.Clear();
            txtboxTotalPris.Clear();
            AdvIdTextBox.Clear();
        }


        private void btnOpretSag_Click(object sender, EventArgs e)
        {
            try
            {
                //Konverter dato fra bruger og til datetime TYPE
                string startDato = dateTimePickerStart.Value.ToString("yyyy-MM-dd");
                string slutDato = dateTimePickerSlut.Value.ToString("yyyy-MM-dd");

                string titel = txtboxSagTitel.Text;
                int totalPris = Convert.ToInt32(txtboxPris.Text);
                int kID = Convert.ToInt32(txtboxKlientId.Text);
                int antalTimer = Convert.ToInt32(txtboxAntalTimer.Text);
                int mID = Convert.ToInt32(txtboxAdvokatId.Text);

                sController.OpretSag(titel, startDato, slutDato, antalTimer, totalPris, kID, mID);
                MessageBox.Show("Klientens sag er nu oprettet..");
                UpdateList();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnOpretYdelser_Click(object sender, EventArgs e)
        {
            try
            {
                int sNr = Convert.ToInt32(txtboxSagsNummer.Text);
                int yNr = Convert.ToInt32(txtboxYdelseId.Text);
                double totalTimer = Convert.ToDouble(txtboxTotalTimer.Text);
                double totalPris = Convert.ToDouble(txtboxTotalPris.Text);
                int antalKm = Convert.ToInt32(txtboxKorsel.Text);
                int advokatId = Convert.ToInt32(AdvIdTextBox.Text);
                sController.OpretSagDetaljer(sNr, yNr, totalTimer, antalKm, totalPris,advokatId);
                sController.IndtastEkstraPrisogTimer(sNr, totalPris, totalTimer);
                MessageBox.Show("Sagens ydelse(er) er nu tilføjet..");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSorterSager_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sController.HentSag(dt);
            SagFormDataGritVew.DataSource = dt;
        }

        private void btnSorterYdelser_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            yController.HentAdvokatOgYdelse(dt);
            SagFormDataGritVew.DataSource = dt;
        }

        private void openHelpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilHjælpeFil\\Sager.pdf");
        }

        private void FullSagerbtn_Click(object sender, EventArgs e)
        {
            ShowSagGridView();
        }

        public void ShowSagGridView()
        {
            DataTable dt = new DataTable();
            sController.HentFullSag(dt);
            SagFormDataGritVew.DataSource = dt;
        }

        private void Sogbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int klientNr = Convert.ToInt32(KlientNrTextBox.Text);
                DataTable dt = new DataTable();
                sController.HentKlientSag(dt, klientNr);
                SagFormDataGritVew.DataSource = dt;
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void slet_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                int sagID = Convert.ToInt32(SagFormDataGritVew.CurrentRow.Cells[0].Value);
                string sagTitelNavn = SagFormDataGritVew.CurrentRow.Cells[1].Value.ToString();

                MessageBox.Show("Du har valgt Sagen: " + sagTitelNavn + " som har identifikationsnummeret: " + sagID);
                if (MessageBox.Show("Er du sikker på at du vil slette sagen med identifikationsnummer: " + sagID + "?", "SAG | SLET", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    sController.SletSag(sagID);
                    MessageBox.Show("Klienten er nu slettet..");
                    UpdateList();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void SagFormDataGritVew_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxSagTitel.Text = SagFormDataGritVew.CurrentRow.Cells[1].Value.ToString();
            dateTimePickerStart.Text = SagFormDataGritVew.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerSlut.Text = SagFormDataGritVew.CurrentRow.Cells[3].Value.ToString();
            txtboxAntalTimer.Text = SagFormDataGritVew.CurrentRow.Cells[4].Value.ToString();
            txtboxPris.Text = SagFormDataGritVew.CurrentRow.Cells[5].Value.ToString();
            txtboxKlientId.Text = SagFormDataGritVew.CurrentRow.Cells[6].Value.ToString();
            txtboxAdvokatId.Text = SagFormDataGritVew.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
