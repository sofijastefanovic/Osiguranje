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
    public partial class UsevDodajForma : Form
    {
        public bool DodatniPodaciUneti { get; private set; } = false;
        public string Vrsta { get; private set; } = "";
        public string Lokacija { get; private set; } = "";
        public decimal ProcenjenaVrednost { get; private set; } = 0;

        public UsevDodajForma()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVrsta.Text))
            {
                MessageBox.Show("Molimo unesite vrstu useva!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLokacija.Text))
            {
                MessageBox.Show("Molimo unesite lokaciju!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtProcenjenaVrednost.Text, out decimal vrednost))
            {
                MessageBox.Show("Procenjena vrednost mora biti broj (npr. 150000.5)!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Vrsta = txtVrsta.Text;
            Lokacija = txtLokacija.Text;
            ProcenjenaVrednost = vrednost;
            DodatniPodaciUneti = true;

            MessageBox.Show("Podaci za usev su sačuvani!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProcenjenaVrednost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLokacija_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVrsta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
