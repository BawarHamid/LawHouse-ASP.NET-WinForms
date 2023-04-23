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

namespace WinFormsAppLawHouse.GUI.Personale.Ydelse
{
    public partial class TilføjAdvokatForms : Form
    {

        YdelseController yCon;
        MedarbejderController mCon;

        public TilføjAdvokatForms()
        {
            mCon = MedarbejderController.GetIntance();
            yCon =  YdelseController.GetIntance();

            InitializeComponent();

            DataTable dt = new DataTable();
            yCon.HentAdvokatOgYdelse(dt);
            AdvokatView.DataSource = dt;
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
            AdvokatView.DataSource = yCon.HentYdelse();

            AdvokatIDTxtB.Clear();
            YdelseIDTxtB.Clear();

        }

        private void TilføjBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ydelseNr = Convert.ToInt32(YdelseIDTxtB.Text);
                int advokatNr = Convert.ToInt32(AdvokatIDTxtB.Text);
                yCon.TilføjAdvokatYdelse(advokatNr, ydelseNr);
                MessageBox.Show("Du har nu tilføj advokat nummer " + advokatNr + " Til Ydelse nummer " + ydelseNr);
                UpdateList();
            }
            catch (Exception)
            {
                MessageBox.Show("The input - string was not in correct format, try again..", "INPUT | ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void openHelpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilHjælpeFil\\TilføjAdvokat.pdf");
        }

        private void ydelerBtn_Click(object sender, EventArgs e)
        {
            AdvokatView.DataSource = yCon.HentYdelse();
        }

        private void AdvoBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            mCon.HentAdvokat(dt);
            AdvokatView.DataSource = dt;
        }

        private void AdvYdBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            yCon.HentAdvokatOgYdelse(dt);
                AdvokatView.DataSource = dt;
        }

        private void SletBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ydelseNr = Convert.ToInt32(YdelseIDTxtB.Text);
                int advokatNr = Convert.ToInt32(AdvokatIDTxtB.Text);
                yCon.SletAdvokatYdelse(advokatNr);
                MessageBox.Show("Du har nu fjernet advokat nummer " + advokatNr + " fra ydelsen nummer " + ydelseNr );
                UpdateList();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("The input - string was not in correct format, try again..", "INPUT | ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdvokatView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AdvokatIDTxtB.Text = AdvokatView.CurrentRow.Cells[0].Value.ToString();
            YdelseIDTxtB.Text = AdvokatView.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
