using ConsoleApplicationLawHouse.Forretningslogik;
using ConsoleApplicationLawHouse.Forretningslogik.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLawHouse.GUI.Personale.Medarbejdere
{
    public partial class OpretMedarbejderForms : Form
    {
        MedarbejderController mController;
        string imageName;
        

        public OpretMedarbejderForms()
        {
            mController = MedarbejderController.GetIntance();
            InitializeComponent();
            MedarbejderView.DataSource = mController.HentMedarbejder();
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
            MedarbejderView.DataSource = mController.HentMedarbejder();
            navnTxtBox.Clear();
            efterNavnTxtBox.Clear();
            emailTxtBox.Clear();
            tlfNrTxtBox.Clear();
            comboBox1.SelectedItem = null;
            EfteruddTextBox.Clear();
            medarbilledPbox.Image = null;
        }

        private void browseBttn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int randomTal = r.Next();

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "*.png; All files;|*.png; All files;";
                //dialog.Filter = "PNG FILES (.png)|.png|All files (.)|.";
                dialog.Title = "Valg af Medarbejderportræt!";
                string picLocation;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    picLocation = dialog.FileName.ToString();
                    File.Copy(picLocation, "..//..//..//Other//Billeder//medarbejder//" + randomTal);
                    imageName = randomTal.ToString();
                    medarbilledPbox.ImageLocation = picLocation;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void OpretBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string forNavn = navnTxtBox.Text;
                string efterNavn = efterNavnTxtBox.Text;
                string email = emailTxtBox.Text;
                int telefonNr = Convert.ToInt32(tlfNrTxtBox.Text);
                string stillingstype = comboBox1.SelectedItem.ToString();
                string efterUdd = EfteruddTextBox.Text;

                if (mController.IsEmployeeExistingE(email) == false && mController.IsEmployeeExistingT(telefonNr) == false)
                {
                    MessageBox.Show("Du opretter nu medarbejderen: " + forNavn + " " + efterNavn);
                    mController.OpretMedarbejder(new Medarbejder(forNavn, efterNavn, email, telefonNr, imageName, stillingstype, efterUdd));
                    MessageBox.Show("Medarbejderen er nu oprettet.." + "\n" + "\n" + "Næste gang der benyttes personale login skal fornavn og medarbejder identifikationsnummer indtastes!", "MEARBEJDER | OPRET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateList();
                }
                else
                {
                    MessageBox.Show("Medarbejderen findes allerede..", "OPRET | FEJL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }

    
        }

        private void SletBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int medarbejderID = Convert.ToInt32(MedarbejderView.CurrentRow.Cells[0].Value);
                string forNavn = MedarbejderView.CurrentRow.Cells[1].Value.ToString();
                string efterNavn = MedarbejderView.CurrentRow.Cells[2].Value.ToString();

                MessageBox.Show("Du har valgt medarbejderen: " + forNavn + " " + efterNavn + " som har identifikationsnummeret: " + medarbejderID);
                if (MessageBox.Show("Er du sikker på at du vil slette medarbejderen med identifikationsnummer: " + medarbejderID + "?", "MEDARBEJDER | SLET", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    mController.SletMedarbejder(medarbejderID);
                    MessageBox.Show("Medarbejderen er nu slettet..");
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
            string email = emailTxtBox.Text;
            string strTelefonNr = tlfNrTxtBox.Text;
            string stillingsType = comboBox1.SelectedItem.ToString();
            string efterUdd = EfteruddTextBox.Text;

            if (forNavn.Equals("") || efterNavn.Equals("") || email.Equals("") || strTelefonNr.Equals("") || strTelefonNr.Any(char.IsLetter))
            {
                MessageBox.Show("Inputstrengen var ikke i korrekt format - prøv igen!", "INPUT | FEJL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int telefonNr = Convert.ToInt32(strTelefonNr);
                if (mController.IsEmployeeExistingE(email) == false || mController.IsEmployeeExistingT(telefonNr) == false)
                {
                    int medarbejderID = Convert.ToInt32(MedarbejderView.CurrentRow.Cells[0].Value);
                    MessageBox.Show("Du har valgt medarbejderen: " + forNavn + " som har identifikationsnummeret: " + medarbejderID);
                    if (MessageBox.Show("Er du sikker på at du vil opdatere medarbejderen med identifikationsnummer: " + medarbejderID + "?", "MEDARBEJDER | OPDATER", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        mController.OpdaterMedarbejder(forNavn, efterNavn, email, telefonNr, medarbejderID);
                        MessageBox.Show("Du har nu opdateret den valgte medarbejder..", "MEDARBEJDER | OPDATER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateList();
                    }
                }
                else
                {
                    MessageBox.Show("Der er et eller flere bestemte informationer som allerede tilhører en eksisterende medarbejder.." + "\n" + "\n" + "Prøv igen med andet telefonnummer og(eller) email..", "OPDATER | FEJL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MedarbejderView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTxtBox.Text = MedarbejderView.CurrentRow.Cells[0].Value.ToString();
            navnTxtBox.Text = MedarbejderView.CurrentRow.Cells[1].Value.ToString();
            efterNavnTxtBox.Text = MedarbejderView.CurrentRow.Cells[2].Value.ToString();
            emailTxtBox.Text = MedarbejderView.CurrentRow.Cells[3].Value.ToString();
            tlfNrTxtBox.Text = MedarbejderView.CurrentRow.Cells[4].Value.ToString();
            comboBox1.SelectedItem = MedarbejderView.CurrentRow.Cells[6].Value.ToString();
            EfteruddTextBox.Text = MedarbejderView.CurrentRow.Cells[7].Value.ToString();
        }

        private void openHelpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilHjælpeFil\\Medarbejder.pdf\\");
        }

        private void RydBtn_Click(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}
