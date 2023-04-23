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

namespace WinFormsAppLawHouse.GUI.Selvbetjening
{
    public partial class BegregningerForms : Form
    {
        


        public BegregningerForms()
        {
            InitializeComponent();
        }

        public void StartProcess(string sti)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(sti)
            {
                UseShellExecute = true
            };
            p.Start();
        }

        

        private void openHelpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilHjælpeFil\\Beregninger.pdf");
        }

        private void BegregningerForms_Load(object sender, EventArgs e)
        {

        }
    }
}
