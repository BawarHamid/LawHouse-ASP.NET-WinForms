using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLawHouse.GUI.Selvbetjening
{
    public partial class SelvbetjeningForms : Form
    {
        Thread th;

        private Button currentButton;
        private Form activeForm;

        public SelvbetjeningForms()
        {
            InitializeComponent();

            KørselsfradragBtn.Hide();
            GaveafgiftBtn.Hide();
            TinglysningsafgiftBtn.Hide();
            YdelsepålånBtn.Hide();

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

     

        
        private void FormularerBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormularForms(), sender);
            KørselsfradragBtn.Hide();
            GaveafgiftBtn.Hide();
            TinglysningsafgiftBtn.Hide();
            YdelsepålånBtn.Hide();
        }

        private void BeregningerBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BegregningerForms(), sender);

            KørselsfradragBtn.Show();
            GaveafgiftBtn.Show();
            TinglysningsafgiftBtn.Show();
            YdelsepålånBtn.Show();
        }

        private void KørselsfradragBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KørselsfradragForms(), sender);
        }

        private void GaveafgiftBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GaveafgiftForms(), sender);

        }

        private void TinglysningsafgiftBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TinglysningsFroms(), sender);

        }

        private void YdelsepålånBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new YdelsePåLånForms(), sender);

        }

        private void TilbageBtn_Click(object sender, EventArgs e)
        {
            KørselsfradragBtn.Hide();
            GaveafgiftBtn.Hide();
            TinglysningsafgiftBtn.Hide();
            YdelsepålånBtn.Hide();

   

            OpenChildForm(new StartsideFroms(), sender);

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

   

    }
}
