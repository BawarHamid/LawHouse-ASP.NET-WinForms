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
    public partial class TinglysningsFroms : Form
    {
        BeregningerController bc =  BeregningerController.GetIntance();
        public TinglysningsFroms()
        {
            InitializeComponent();
        }

        private void btnBeregn_Click(object sender, EventArgs e)
        {
            try
            {
                double pris = Convert.ToDouble(prisTextBox.Text);
                double result = bc.BeregnTinglysningafgift(pris);

                resultTextBox.Text = Convert.ToString(result);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("det kan indtastes kun tal ");
            }
        }

        private void TinglysningsFroms_Load(object sender, EventArgs e)
        {

        }
    }
}
