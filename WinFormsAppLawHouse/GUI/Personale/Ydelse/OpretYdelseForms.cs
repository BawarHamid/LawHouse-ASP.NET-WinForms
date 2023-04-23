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
    public partial class OpretYdelseForms : Form
    {
        YdelseController yCon;

        public OpretYdelseForms()
        {
            yCon = YdelseController.GetIntance();
            InitializeComponent();
            YdelserView.DataSource = yCon.HentYdelse();
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
            YdelserView.DataSource = yCon.HentYdelse();
            YdelseNavnTxtB.Clear();
            TypePrisTxtB.Clear();
            YdelseIDTxtB.Clear();
        }

        private void OpretBtn_Click(object sender, EventArgs e)
        {
            string ydelseNavn = YdelseNavnTxtB.Text;
            string typePris = TypePrisTxtB.Text;

            if (ydelseNavn.Equals("") || typePris.Equals(""))
            {
                MessageBox.Show("Inputstrengen var ikke i korrekt format - prøv igen!", "INPUT | FEJL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Vil du oprette ydelsen: " + ydelseNavn + " med typeprisen: " + typePris + "?", "YDELSE | OPRET", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    yCon.OpretYdelse(ydelseNavn, typePris);
                    MessageBox.Show("Ydelsen er nu oprettet..");
                    UpdateList();
                }
            }
        }

        private void SeltBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ydelseID = Convert.ToInt32(YdelserView.CurrentRow.Cells[0].Value);
                string ydelseNavn = YdelserView.CurrentRow.Cells[1].Value.ToString();

                MessageBox.Show("Du har valgt ydelsen: " + ydelseNavn + " som har identifikationsnummeret: " + ydelseID);
                if (MessageBox.Show("Er du sikker på at du vil slette ydelsen med identifikationsnummer: " + ydelseID + "?", "YDELSE | SLET", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    yCon.SletYdelse(ydelseID);
                    MessageBox.Show("Ydelsen er nu slettet..");
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
            string ydelseNavn = YdelseNavnTxtB.Text;
            string typePris = TypePrisTxtB.Text;

            if (ydelseNavn.Equals("") || typePris.Equals(""))
            {
                MessageBox.Show("Inputstrengen var ikke i korrekt format - prøv igen!", "INPUT | FEJL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ydelseID = Convert.ToInt32(YdelserView.CurrentRow.Cells[0].Value);
                MessageBox.Show("Du har valgt ydelsen: " + ydelseNavn + " som har identifikationsnummeret: " + ydelseID);
                if (MessageBox.Show("Er du sikker på at du vil opdatere ydelsen med identifikationsnummer: " + ydelseID + "?", "YDELSE | OPDATER", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    yCon.OpdaterYdelse(ydelseNavn, typePris, ydelseID);
                    MessageBox.Show("Den valgte ydelse er nu opdateret..", "YDELSE | OPDATER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateList();
                }
            }
        }

        private void YdelserView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            YdelseIDTxtB.Text = YdelserView.CurrentRow.Cells[0].Value.ToString();
            YdelseNavnTxtB.Text = YdelserView.CurrentRow.Cells[1].Value.ToString();
            TypePrisTxtB.Text = YdelserView.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void openHelpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilHjælpeFil\\Ydelser.pdf");
        }
    }
}
