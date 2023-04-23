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
    public partial class YdelseDataGridViewForms : UserControl
    {
        YdelseController yCon;
        SagController sCon;

        public YdelseDataGridViewForms()
        {
            yCon = YdelseController.GetIntance();
            sCon = SagController.GetIntance();

            InitializeComponent();

            LoadYdelserSag();
        }

        public void LoadYdelserSag()
        {
            try
            {
                DataTable dt = new DataTable();
                yCon.HentYdelse();
                YdelseView.DataSource = dt;
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
                YdelseView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
