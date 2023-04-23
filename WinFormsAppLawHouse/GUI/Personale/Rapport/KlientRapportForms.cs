using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLawHouse.GUI.Personale.Rapport
{
    public partial class KlientRapportForms : Form
    {
        public KlientRapportForms()
        {
            InitializeComponent();
        }

        public void UpdateList()
        {
            RapportRTB.Clear();
            FilNavnTxtB.Clear();
      
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
        public void UdskrivRapport(string tekst, string tekstNavn)
        {
            try
            {
                string filePath = "..\\..\\..\\Other\\KlientRapportMappe\\" + tekstNavn + ".txt";
                StreamWriter intext = new StreamWriter(filePath);
                intext.WriteLine(tekst);
                intext.Close();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
            
        }

        private void UdskrivBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UdskrivRapport(RapportRTB.Text, FilNavnTxtB.Text);
                MessageBox.Show($"Rapporten er udskrevet med filnavnet: {FilNavnTxtB.Text}.txt");
                UpdateList();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }

        private void openHelpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilHjælpeFil\\KlientRapport.pdf");
        }
    }
}
