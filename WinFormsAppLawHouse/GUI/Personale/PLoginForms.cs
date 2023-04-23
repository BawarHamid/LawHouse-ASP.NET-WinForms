using ConsoleApplicationLawHouse.Forretningslogik.Controllers;
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
using WinFormsAppLawHouse;

namespace WinFormsAppLawHouse.GUI.Personale
{
    public partial class PLoginForms : Form
    {
        Thread th;

        MedarbejderController mCon;

        public PLoginForms()
        {
            mCon = MedarbejderController.GetIntance();
            InitializeComponent();
        }

        private void LogPaaBtn_Click(object sender, EventArgs e)
        {
            string navn = NavnTxtB.Text;
            string strID = MedarbejderIDTxtB.Text;

            if (navn.Equals("") || strID.Equals("") || strID.Any(char.IsLetter))
            {
                MessageBox.Show("            Ugyldigt fornavn eller identifikationsnummer            ");
            }
            else
            {
                int ID = Convert.ToInt32(strID);
                if (mCon.MedarbejderLogin(navn, ID))
                {
                    this.Close();
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("           Medarbejderen eksisterer ikke i LawHouses database..           ");
                }
            }
        }

        private void opennewform(object obj)
        {
            Application.Run(new PersonaleForms());
        }
    }
}
