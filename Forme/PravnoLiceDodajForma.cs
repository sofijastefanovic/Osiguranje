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
    public partial class PravnoLiceDodajForma : Form
    {
        public bool DodatniPodaciUneti { get; private set; } = false;
        public string Pib { get; private set; } = "";
        public string MaticniBroj { get; private set; } = "";
        public string Delatnost { get; private set; } = "";
        public string KontaktOsobe { get; private set; } = "";

        public PravnoLiceDodajForma()
        {
            InitializeComponent();
        }

        private void txtPib_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaticniBroj_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDelatnost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKontaktOsobe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPib.Text))
            {
                MessageBox.Show("Molimo unesite PIB!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaticniBroj.Text))
            {
                MessageBox.Show("Molimo unesite matični broj!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDelatnost.Text))
            {
                MessageBox.Show("Molimo unesite delatnost!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKontaktOsobe.Text))
            {
                MessageBox.Show("Molimo unesite kontakt osobe!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pib = txtPib.Text;
            MaticniBroj = txtMaticniBroj.Text;
            Delatnost = txtDelatnost.Text;
            KontaktOsobe = txtKontaktOsobe.Text;
            DodatniPodaciUneti = true;

            MessageBox.Show("Podaci za pravno lice su sačuvani!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
