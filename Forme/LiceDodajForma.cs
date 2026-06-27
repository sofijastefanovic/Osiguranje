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
    public partial class LiceDodajForma : Form
    {
        public bool DodatniPodaciUneti { get; private set; } = false;
        public string Jmbg { get; private set; } = "";
        public string Ime { get; private set; } = "";
        public string Prezime { get; private set; } = "";
        public DateTime DatumRodjenja { get; private set; } = DateTime.Now;

        public LiceDodajForma()
        {
            InitializeComponent();
            dtpDatumRodjenja.Value = DateTime.Now.AddYears(-30);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJmbg.Text))
            {
                MessageBox.Show("Molimo unesite JMBG!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Molimo unesite ime!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Molimo unesite prezime!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Jmbg = txtJmbg.Text;
            Ime = txtIme.Text;
            Prezime = txtPrezime.Text;
            DatumRodjenja = dtpDatumRodjenja.Value;
            DodatniPodaciUneti = true;

            MessageBox.Show("Podaci za lice su sačuvani!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void dtpDatumRodjenja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJmbg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
