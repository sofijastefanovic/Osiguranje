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
    public partial class VoziloDodajForma : Form
    {
        public bool DodatniPodaciUneti { get; private set; } = false;
        public string Registracija { get; private set; } = "";
        public string Marka { get; private set; } = "";
        public string Model { get; private set; } = "";
        public int GodinaProizvodnje { get; private set; } = 0;
        public string ImeVlasnika { get; private set; } = "";
        public string PrezimeVlasnika { get; private set; } = "";

        public VoziloDodajForma()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistracija.Text))
            {
                MessageBox.Show("Molimo unesite registraciju!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMarka.Text))
            {
                MessageBox.Show("Molimo unesite marku!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Molimo unesite model!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtGodinaProizvodnje.Text, out int godina))
            {
                MessageBox.Show("Godina proizvodnje mora biti broj!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtImeVlasnika.Text))
            {
                MessageBox.Show("Molimo unesite ime vlasnika!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrezimeVlasnika.Text))
            {
                MessageBox.Show("Molimo unesite prezime vlasnika!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Registracija = txtRegistracija.Text;
            Marka = txtMarka.Text;
            Model = txtModel.Text;
            GodinaProizvodnje = godina;
            ImeVlasnika = txtImeVlasnika.Text;
            PrezimeVlasnika = txtPrezimeVlasnika.Text;
            DodatniPodaciUneti = true;

            MessageBox.Show("Podaci za vozilo su sačuvani!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }

        private void txtPrezimeVlasnika_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImeVlasnika_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGodinaProizvodnje_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegistracija_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
