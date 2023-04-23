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

namespace WinFormsAppLawHouse.GUI.Selvbetjening
{
    public partial class YdelsePåLånForms : Form
    {
        BeregningerController bc =  BeregningerController.GetIntance();
        public YdelsePåLånForms()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBeregn_Click(object sender, EventArgs e)
        {
            try
            {

                double lån = Convert.ToDouble(LånStørrelseTextBox.Text);
                double rente = Convert.ToDouble(RentePAarTextBox.Text);
                int antalÅr = Convert.ToInt32(AntalårTextBox.Text);
                double result = bc.BeregnLån(lån, rente, antalÅr);
                ResultTxtBox.Text = Convert.ToString(result);
            }
            catch (Exception)
            {
                MessageBox.Show("Indtast oplysningerne i  felterne på den korrekte form");
            }
        }

        private void YdelsePåLånForms_Load(object sender, EventArgs e)
        {

        }
    }
}
