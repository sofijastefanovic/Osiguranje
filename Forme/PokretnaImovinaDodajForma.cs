using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osiguranje.Forme
{
    public partial class PokretnaImovinaDodajForma : Form
    {
        public bool DodatniPodaciUneti { get; private set; } = false;
        public string SerijskiBroj { get; private set; } = "";
        public string Naziv { get; private set; } = "";
        public string Opis { get; private set; } = "";
        public decimal ProcenjenaVrednost { get; private set; } = 0;

        public PokretnaImovinaDodajForma()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSerijskiBroj.Text))
            {
                MessageBox.Show("Molimo unesite serijski broj!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Molimo unesite naziv!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                MessageBox.Show("Molimo unesite opis!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtProcenjenaVrednost.Text, out decimal vrednost))
            {
                MessageBox.Show("Procenjena vrednost mora biti broj (npr. 150000.5)!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SerijskiBroj = txtSerijskiBroj.Text;
            Naziv = txtNaziv.Text;
            Opis = txtOpis.Text;
            ProcenjenaVrednost = vrednost;
            DodatniPodaciUneti = true;

            MessageBox.Show("Podaci za pokretnu imovinu su sačuvani!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void txtProcenjenaVrednost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOpis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSerijskiBroj_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
