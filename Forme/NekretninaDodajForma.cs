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
    public partial class NekretninaDodajForma : Form
    {
        public bool DodatniPodaciUneti { get; private set; } = false;
        public string Adresa { get; private set; } = "";
        public string TipObjekta { get; private set; } = "";
        public int GodinaIzgradnje { get; private set; } = 0;
        public decimal Povrsina { get; private set; } = 0;
        public decimal ProcenjenaVrednost { get; private set; } = 0;

        public NekretninaDodajForma()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MessageBox.Show("Molimo unesite adresu!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTipObjekta.Text))
            {
                MessageBox.Show("Molimo unesite tip objekta!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtGodinaIzgradnje.Text, out int godina))
            {
                MessageBox.Show("Godina izgradnje mora biti broj!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPovrsina.Text, out decimal povrsina))
            {
                MessageBox.Show("Površina mora biti broj (npr. 75.5)!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtProcenjenaVrednost.Text, out decimal vrednost))
            {
                MessageBox.Show("Procenjena vrednost mora biti broj (npr. 150000.5)!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Adresa = txtAdresa.Text;
            TipObjekta = txtTipObjekta.Text;
            GodinaIzgradnje = godina;
            Povrsina = povrsina;
            ProcenjenaVrednost = vrednost;
            DodatniPodaciUneti = true;

            MessageBox.Show("Podaci za nekretninu su sačuvani!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void txtProcenjenaVrednost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPovrsina_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGodinaIzgradnje_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipObjekta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
