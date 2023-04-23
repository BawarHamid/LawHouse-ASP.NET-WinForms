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
using System.Windows.Forms;

namespace WinFormsAppLawHouse.GUI.Selvbetjening
{
    public partial class KørselsfradragForms : Form
    {
        BeregningerController bc =  BeregningerController.GetIntance();
        public KørselsfradragForms()
        {
            InitializeComponent();
        }

        private void btnBeregn_Click(object sender, EventArgs e)
        {
            try
            {
                double antalKm = Convert.ToDouble(kmTextBox.Text);
                int antalDage = Convert.ToInt32(dageTextBox.Text);

                double kørselfradrag = bc.BeregnKørselfradrag(antalKm, antalDage);
                if (kørselfradrag == 0)
                {
                    fradragTextBox.Text = Convert.ToString(kørselfradrag);
                    MessageBox.Show("Du har ikke nok km for kørselfradrag");
                }
                else
                {
                    fradragTextBox.Text = Convert.ToString(kørselfradrag);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Udfyld de nøvdendige felter i den korekte form");
            }

        }
    }
}
