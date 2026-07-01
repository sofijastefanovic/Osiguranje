using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Osiguranje.Forme;

namespace Osiguranje.Forme
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void btnKlijent_Click(object sender, EventArgs e)
        {
            KlijentForma otvoriKlijenta = new KlijentForma();
            otvoriKlijenta.ShowDialog();
        }

        private void btnPolisa_Click(object sender, EventArgs e)
        {
            PolisaForma otvoriPolisu = new PolisaForma();
            otvoriPolisu.ShowDialog();
        }

        private void btnSteta_Click(object sender, EventArgs e)
        {
            StetaForma otvoriStetu = new StetaForma();
            otvoriStetu.ShowDialog();
        }

        private void btnProcena_Click(object sender, EventArgs e)
        {
            ProcenaForma otvoriProcenu = new ProcenaForma();
            otvoriProcenu.ShowDialog();
        }

        private void btnAngazovana_Click(object sender, EventArgs e)
        {
            AngazovanaForma otvoriAngazovanuOsobu = new AngazovanaForma();
            otvoriAngazovanuOsobu.ShowDialog();
        }
        private void btnFaza_Click(object sender, EventArgs e)
        {
            FazaObradeSteteForma otvoriFazu = new FazaObradeSteteForma();
            otvoriFazu.ShowDialog();
        }

        private void btnPredmet_Click(object sender, EventArgs e)
        {
            PredmetOsiguranjaForma otvoriPredmetOsiguranja = new PredmetOsiguranjaForma();
            otvoriPredmetOsiguranja.ShowDialog();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
