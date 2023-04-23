using ConsoleApplicationLawHouse.Forretningslogik;
using ConsoleApplicationLawHouse.Forretningslogik.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using WinFormsAppLawHouse.GUI.Personale.Klienter;
using WinFormsAppLawHouse.GUI.Personale.Medarbejdere;
using WinFormsAppLawHouse.GUI.Personale.Sager;
using WinFormsAppLawHouse.GUI.Personale.Ydelse;
using WinFormsAppLawHouse.GUI.Personale.Rapport;
using System.Diagnostics;

namespace WinFormsAppLawHouse.GUI.Personale
{
    public partial class PersonaleForms : Form
    {
        Thread th;

        MedarbejderController mCon;
        private Button currentButton;
        private Form activeForm;

        public PersonaleForms()
        {
            mCon = MedarbejderController.GetIntance();
            InitializeComponent();
            Task.WhenAll(ShowEmployees1(mCon.ShowEmployeesTask()));
            Task.WhenAll(ShowEmployees2(mCon.ShowEmployeesTask()));
            OpretKlientBtn.Hide();
            OpretMedarbejderBtn.Hide();
            TilføjAdvokatydelseBtn.Hide();
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

        // vi har lavet to async task Show medarbejder metoder
        private async Task ShowEmployees1(List<Medarbejder> medarbejdere)
        {
            int i = 0;
            while (true)
            {
                //her sætter vi værdier på de forskllige textboxes og gøre dem til read only så der kan ikke skrives noget i
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
                // når man har en asyn metode skal der altid lave await
                // vi har sæt en delay så de skiftes medarbejder lidt langsom
                // når man bruger async så kan metoden køre parralelt med resten af programmet 
                await Task.Delay(10000);
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
                await Task.Delay(10000);
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

        private void SagBtn_Click(object sender, EventArgs e)
        {
            TilføjAdvokatydelseBtn.Hide();
            OpretKlientBtn.Hide();
            OpretMedarbejderBtn.Hide();

            OpenChildForm(new SagerForms(), sender);
        }

        private void MedarbejderBtn_Click(object sender, EventArgs e)
        {

            TilføjAdvokatydelseBtn.Hide();
            OpretKlientBtn.Hide();


            OpenChildForm(new MedarbejderForms(), sender);
            OpretMedarbejderBtn.Show();
        }

        private void OpretMedarbejderBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OpretMedarbejderForms(), sender);

        }

        private void KlinterBtn_Click(object sender, EventArgs e)
        {
            OpretMedarbejderBtn.Hide();
            TilføjAdvokatydelseBtn.Hide();

            OpenChildForm(new KlientForms(), sender);
            OpretKlientBtn.Show();
        }

        private void OpretKlientBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OpretKlientForms(), sender);
        }

        private void TilføjYdelseBtn_Click(object sender, EventArgs e)
        {
            OpretMedarbejderBtn.Hide();
            OpretKlientBtn.Hide();


            OpenChildForm(new OpretYdelseForms(), sender);
            TilføjAdvokatydelseBtn.Show();

        }

        private void TilføjAdvokatydelseBtn_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new TilføjAdvokatForms(), sender);
        }

        private void KlientRapportBtn_Click(object sender, EventArgs e)
        {
            OpretMedarbejderBtn.Hide();
            OpretKlientBtn.Hide();
            TilføjAdvokatydelseBtn.Hide();
            OpenChildForm(new KlientRapportForms(), sender);
        }

        private void TilbageBtn_Click(object sender, EventArgs e)
        {
            OpretMedarbejderBtn.Hide();
            OpretKlientBtn.Hide();
            TilføjAdvokatydelseBtn.Hide();

            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void LogudBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ARE YOU SURE YOU WANT TO LOG OUT", "EXIT :", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void opennewform(object obj)
        {
            Application.Run(new MainMenuForms());
        }

        private void HelpMeBtn_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilHjælpeFil\\PersonaleMenu.pdf");
        }


    }
}