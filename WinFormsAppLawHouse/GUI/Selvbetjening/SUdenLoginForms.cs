using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLawHouse.GUI.Selvbetjening
{
    public partial class SUdenLoginForms : Form
    {
        Thread th;

        public SUdenLoginForms()
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

        private void TilbageBtn_Click(object sender, EventArgs e)
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

        private void BoligklageBtn_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilFormular\\Boligklagepakke.pdf");
            //System.Diagnostics.Process.Start("..\\..\\..\\Other\\DokumenterTilFormular\\Boligklagepakke.pdf");
            //MessageBox.Show("Om denne pakke: Hvis du som lejer i en privat udlejningsejendom mener, at din husleje er for høj i forhold til dit lejemåls størrelse og standard, kan du benytte denne formular-pakke." + "\n" + "\n" + "Pris: 200,00 kr.", "Boligklagepakke", MessageBoxButtons.OK);
        }

        private void OpløsningspakkeBtn_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilFormular\\Opløsningspakke.pdf");
            //System.Diagnostics.Process.Start("..\\..\\..\\Other\\DokumenterTilFormular\\Opløsningspakke.pdf");
            //MessageBox.Show("Om denne pakke: Hvis I skal i gang med - eller allerede er i gang med - at opløse et papirløst samlivsforhold, gør I klogt i at indgå forskellige aftaler. I tilfælde af voldsom uenighed kommer I nemlig meget let ud i det juridiske grænseland, hvor selv oplagte uretfærdigheder ikke kan ryddes af vejen ved hjælp af besværlige - og ofte bekostelige - retssager." + "\n" + "\n" + "Pris: 450,00 kr.", "Opløsningspakke", MessageBoxButtons.OK);
        }

        private void ægtefældeBidragBtn_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilFormular\\Ægtefællebidrag.pdf");
            //System.Diagnostics.Process.Start("..\\..\\..\\Other\\DokumenterTilFormular\\Ægtefællebidrag.pdf");
            //MessageBox.Show("Om denne pakke: Formularen er beregnet til ægtefæller, som i forbindelse med en aktuel forestående separation eller skilsmisse er enige om bidragspligtens varighed og bidragets størrelse. Er I enige om bidragsperiodens længde, kan I aftale dette og overlade det til Familieretshuset at træffe afgørelse om bidragets størrelse." + "\n" + "\n" + "Pris: 250,00 kr.", "Ægtefællebidrag", MessageBoxButtons.OK);
        }

        private void KøbsaftaleVillaBtn_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilFormular\\Købsaftale.pdf");
            //System.Diagnostics.Process.Start("..\\..\\..\\Other\\DokumenterTilFormular\\Købsaftale.pdf");
            //MessageBox.Show("Om denne pakke: Vi kan nu tilbyde dig en formular til en købsaftale vedrørende en villa. Købsaftalen er den bindende aftale mellem køber og sælger, hvor handelens præcise vilkår aftales. Aftalen skal tinglyses digitalt, og der medfølger kort vejledning i, hvorledes købsaftalen tinglyses. Formularen kan anvendes, hvis du vil købe eller sælge en villa i situationer, hvor der ikke medvirker ejendomsmægler." + "\n" + "\n" + "Pris: 400,00 kr.", "Købsaftale Villa", MessageBoxButtons.OK);
        }

        private void DødsfaldsBtn_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilFormular\\Dødsfaldspakke.pdf");
            //System.Diagnostics.Process.Start("..\\..\\..\\Other\\DokumenterTilFormular\\Dødsfaldspakke.pdf");
            //MessageBox.Show("Om denne pakke: Du har blandt andet ret til at bestemme, om du vil begraves i en kiste eller i en urne. Tillige kan du forpligte dine efterladte - eller begravelsesmyndigheden - hvad angår begravelseshandlingen, dvs. om den skal være kirkelig eller borgerlig. Du kan også komme med dine tilkendegivelser om, hvor du ønsker at blive begravet, og hvordan din begravelse ellers skal foregå." + "\n" + "\n" + "Pris: 200,00 kr.", "Dødsfaldspakke", MessageBoxButtons.OK);
        }

        private void GældsbrevBtn_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilFormular\\Gældsbrev.pdf");
            //System.Diagnostics.Process.Start("..\\..\\..\\Other\\DokumenterTilFormular\\Gældbrev.pdf");
            //MessageBox.Show("Hvis du har mulighed for at låne eller udlåne penge på særdeles favorable vilkår, kan det i mange tilfælde gøres ved hjælp af et såkaldt rentefrit familielån." + "\n" + "\n" + "Pris: 250,00 kr.", "Gældbrev", MessageBoxButtons.OK);
        }

        private void KøbBtn_Click(object sender, EventArgs e)
        {
            if (BoligklageCB.Checked && OpløsningspakkeCB.Checked)
            {
                MessageBox.Show("Du har valgt følgende formular:" + "\n" + "Boligklagepakke & Opløsningspakke" + "\n" + "pris ialt = 650,00 kr" );
            }
        }

        private void hjælpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilHjælpeFil\\Formularer.pdf");
        }
    }
}
