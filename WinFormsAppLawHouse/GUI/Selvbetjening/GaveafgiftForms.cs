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
    public partial class GaveafgiftForms : Form
    {
        BeregningerController bc = BeregningerController.GetIntance();
        public GaveafgiftForms()
        {
            InitializeComponent();
        }

        private void btnBeregn_Click(object sender, EventArgs e)
        {
            try
            {
                string person = relationComboBox.Text;

                double beløb = Convert.ToDouble(pengTextBox.Text);
                double result = bc.BeregnGaveafgift(person, beløb);
                resultTextBox.Text = Convert.ToString(result);
            }
            catch (Exception)
            {
                MessageBox.Show("Indtast kun nummer i den nødvendig felt");
            }
        }
    }
}
