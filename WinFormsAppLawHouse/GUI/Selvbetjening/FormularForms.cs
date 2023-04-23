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
    public partial class FormularForms : Form
    {
        public FormularForms()
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

        private void BoligklageBtn_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilFormular\\Boligklagepakke.pdf");
            //System.Diagnostics.Process.Start("..\\..\\..\\Other\\DokumenterTilFormular\\Boligklagepakke.pdf");
            //MessageBox.Show("Om denne pakke: Hvis du som lejer i en privat udlejningsejendom mener, at din husleje er for høj i forhold til dit lejemåls størrelse og standard, kan du benytte denne formular-pakke.", "Boligklagepakke", MessageBoxButtons.OK);
        }

        private void OpløsningspakkeBtn_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilFormular\\Opløsningspakke.pdf");
            //System.Diagnostics.Process.Start("..\\..\\..\\Other\\DokumenterTilFormular\\Opløsningspakke.pdf");
            //MessageBox.Show("Om denne pakke: Hvis I skal i gang med - eller allerede er i gang med - at opløse et papirløst samlivsforhold, gør I klogt i at indgå forskellige aftaler. I tilfælde af voldsom uenighed kommer I nemlig meget let ud i det juridiske grænseland, hvor selv oplagte uretfærdigheder ikke kan ryddes af vejen ved hjælp af besværlige - og ofte bekostelige - retssager.", "Opløsningspakke", MessageBoxButtons.OK);
        }

        private void ægtefældeBidragBtn_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilFormular\\Ægtefællebidrag.pdf");
            //System.Diagnostics.Process.Start("..\\..\\..\\Other\\DokumenterTilFormular\\Ægtefællebidrag.pdf");
            //MessageBox.Show("Om denne pakke: Formularen er beregnet til ægtefæller, som i forbindelse med en aktuel forestående separation eller skilsmisse er enige om bidragspligtens varighed og bidragets størrelse. Er I enige om bidragsperiodens længde, kan I aftale dette og overlade det til Familieretshuset at træffe afgørelse om bidragets størrelse.", "Ægtefællebidrag", MessageBoxButtons.OK);
        }

        private void KøbsaftaleVillaBtn_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilFormular\\Købsaftale.pdf");
            //System.Diagnostics.Process.Start("..\\..\\..\\Other\\DokumenterTilFormular\\Købsaftale.pdf");
            //MessageBox.Show("Om denne pakke: Vi kan nu tilbyde dig en formular til en købsaftale vedrørende en villa. Købsaftalen er den bindende aftale mellem køber og sælger, hvor handelens præcise vilkår aftales. Aftalen skal tinglyses digitalt, og der medfølger kort vejledning i, hvorledes købsaftalen tinglyses. Formularen kan anvendes, hvis du vil købe eller sælge en villa i situationer, hvor der ikke medvirker ejendomsmægler.", "Købsaftale Villa", MessageBoxButtons.OK);
        }

        private void DødsfaldsBtn_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilFormular\\Dødsfaldspakke.pdf");
            //System.Diagnostics.Process.Start("..\\..\\..\\Other\\DokumenterTilFormular\\Dødsfaldspakke.pdf");
            //MessageBox.Show("hej", "Om denne pakke: Du har blandt andet ret til at bestemme, om du vil begraves i en kiste eller i en urne. Tillige kan du forpligte dine efterladte - eller begravelsesmyndigheden - hvad angår begravelseshandlingen, dvs. om den skal være kirkelig eller borgerlig. Du kan også komme med dine tilkendegivelser om, hvor du ønsker at blive begravet, og hvordan din begravelse ellers skal foregå.", MessageBoxButtons.OK);
        }

        private void GældsbrevBtn_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilFormular\\Gældsbrev.pdf");
            //System.Diagnostics.Process.Start("..\\..\\..\\Other\\DokumenterTilFormular\\Gældsbrev.pdf");
            //MessageBox.Show("Hvis du har mulighed for at låne eller udlåne penge på særdeles favorable vilkår, kan det i mange tilfælde gøres ved hjælp af et såkaldt rentefrit familielån.", "Gældbrev", MessageBoxButtons.OK);
        }

        private void openHelpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProcess("..\\..\\..\\Other\\DokumenterTilHjælpeFil\\Formularer.pdf");
        }

        private void helpMeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
