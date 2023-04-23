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
using WinFormsAppLawHouse.GUI.Personale;
using WinFormsAppLawHouse.GUI.Selvbetjening;

namespace WinFormsAppLawHouse
{
    public partial class MainMenuForms : Form
    {
        MedarbejderController medarbController;
        private Button currentButton;
        private Form activeForm;

        public MainMenuForms()
        {
            medarbController = MedarbejderController.GetIntance();
            InitializeComponent();
            Task.WhenAll(ShowEmployees1(medarbController.ShowEmployeesTask()));
            Task.WhenAll(ShowEmployees2(medarbController.ShowEmployeesTask()));
            LogudBtn.Hide();
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

        private async Task ShowEmployees1(List<Medarbejder> medarbejdere)
        {
            int i = 0;
            while (true)
            {
                FornavnTxtB.Text = medarbejdere[(i % medarbejdere.Count())].forNavn;
                FornavnTxtB.ReadOnly = true;
                EfternavnTxtB.Text = medarbejdere[(i % medarbejdere.Count())].efterNavn;
                EfternavnTxtB.ReadOnly = true;
                EmailTxtB.Text = medarbejdere[(i % medarbejdere.Count())].email;
                EmailTxtB.ReadOnly = true;
                TelefonTxtB.Text = medarbejdere[(i % medarbejdere.Count())].telefonNr.ToString();
                TelefonTxtB.ReadOnly = true;
                stillingstypeLabel.Text = medarbejdere[(i % medarbejdere.Count())].stillingsType.ToString();
                MedarbejderPB.ImageLocation = "../../../Other/Billeder/medarbejder/" + medarbejdere[(i % medarbejdere.Count())].billede;
                i++;
                await Task.Delay(5000);
            }
        }

        private async Task ShowEmployees2(List<Medarbejder> medarbejdere)
        {
            int i = 4;
            while (true)
            {
                FornavnTxtB2.Text = medarbejdere[(i % medarbejdere.Count())].forNavn;
                FornavnTxtB2.ReadOnly = true;
                EfternavnTxtB2.Text = medarbejdere[(i % medarbejdere.Count())].efterNavn;
                EfternavnTxtB2.ReadOnly = true;
                EmailTxtB2.Text = medarbejdere[(i % medarbejdere.Count())].email;
                EmailTxtB2.ReadOnly = true;
                TelefonTxtB2.Text = medarbejdere[(i % medarbejdere.Count())].telefonNr.ToString();
                TelefonTxtB2.ReadOnly = true;
                stillingstypeLabel2.Text = medarbejdere[(i % medarbejdere.Count())].stillingsType.ToString();
                MedarbejderPB2.ImageLocation = "../../../Other/Billeder/medarbejder/" + medarbejdere[(i % medarbejdere.Count())].billede;
                i++;
                await Task.Delay(5000);
            }
        }

        private void ActivateButton(object SenderBtn)
        {
            if (SenderBtn != null)
            {
                if (currentButton != (Button)SenderBtn)
                {
                    currentButton = (Button)SenderBtn;
                }
            }
        }

        private void OpenChildForm(Form childForm, object SenderBtn)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(SenderBtn);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleLbl.Text = childForm.Text;

        }

        private void Reset()
        {
            TitleLbl.Text = "HOME";
            currentButton = null;
        }

        private void SelvbetjeningBtn_Click(object sender, EventArgs e)
        {
            PersonaleBtn.Hide();
            OpenChildForm(new SLoginForms(), sender);
        }

        private void PersonaleBtn_Click(object sender, EventArgs e)
        {
            SelvbetjeningBtn.Hide();
            OpenChildForm(new PLoginForms(), sender);
        }

        private void TilbageBtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();

            SelvbetjeningBtn.Show();
            PersonaleBtn.Show();
        }

        private void LukProgram_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ARE YOU SURE YOU WANT TO CLOSE THE APPLICATION", "EXIT :", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void LogudBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ARE YOU SURE YOU WANT TO CLOSE THE APPLICATION", "EXIT :", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void LogoBtn_Click(object sender, EventArgs e)
        {
            MainMenuForms MMF = new MainMenuForms();
            MMF.Show();
            Hide();
        }

   
        private void HelpMeBtn_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilHjælpeFil\\StartMenu.pdf");
        }
    }
}
