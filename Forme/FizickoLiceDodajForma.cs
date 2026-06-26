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
    public partial class FizickoLiceDodajForma : Form
    {
        public bool DodatniPodaciUneti { get; private set; } = false;
        public string Jmbg { get; private set; } = "";
        public DateTime DatumRodjenja { get; private set; } = DateTime.Now;
        public string Zanimanje { get; private set; } = "";

        public FizickoLiceDodajForma()
        {
            InitializeComponent();
            dtpDatumRodjenja.Value = DateTime.Now.AddYears(-30);
        }

        private void txtJmbg_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDatumRodjenja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtZanimanje_TextChanged(object sender, EventArgs e)
        {

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

            if (string.IsNullOrWhiteSpace(txtZanimanje.Text))
            {
                MessageBox.Show("Molimo unesite zanimanje!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Jmbg = txtJmbg.Text;
            DatumRodjenja = dtpDatumRodjenja.Value;
            Zanimanje = txtZanimanje.Text;
            DodatniPodaciUneti = true;

            MessageBox.Show("Podaci za fizičko lice su sačuvani!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
