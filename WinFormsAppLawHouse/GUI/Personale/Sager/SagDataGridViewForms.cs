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

namespace WinFormsAppLawHouse.GUI.Personale.Sager
{
    public partial class SagDataGridViewForms : UserControl
    {
        SagController sCon;

        public SagDataGridViewForms()
        {
            sCon = SagController.GetIntance();

            InitializeComponent();

            LoadSager();
        }

        public void LoadSager()
        {
            try
            {
                DataTable dt = new DataTable();
                sCon.HentSag(dt);
                SagView.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void KlientIDBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int klientId = int.Parse(KlientIDTxtB.Text);
                DataTable dt = new DataTable();
                sCon.HentKlientSag(dt, klientId);
                SagView.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
