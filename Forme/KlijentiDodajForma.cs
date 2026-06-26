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
    public partial class KlijentiDodajForma : Form
    {
        private bool dodatniPodaciUneti = false;

        private string jmbg = "";
        private DateTime datumRodjenja = DateTime.Now;
        private string zanimanje = "";

        private string pib = "";
        private string maticniBroj = "";
        private string delatnost = "";
        private string kontaktOsobe = "";

        private string pibJavna = "";
        private string maticniBrojJavna = "";
        private string delatnostJavna = "";
        private string kontaktOsobeJavna = "";
        private string vrstaInstitucije = "";
        public KlijentiDodajForma()
        {
            InitializeComponent();
            dtpDatumRegistracije.Value = DateTime.Now;
            cmbStatus.SelectedIndex = 0;
            rbFizicko.Checked = true;
        }

        private void txtImePrezimeNaziv_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUlica_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBroj_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDatumRegistracije_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbFizicko_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPravno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbJavnaInstitucija_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDodatniPodaci_Click(object sender, EventArgs e)
        {
            if (rbFizicko.Checked)
            { 
                MessageBox.Show("Otvaranje forme za fizičko lice");
                dodatniPodaciUneti = true;
            }
            else if (rbPravno.Checked)
            {
                MessageBox.Show("Otvaranje forme za pravno lice");
                dodatniPodaciUneti = true;
            }
            else if (rbJavnaInstitucija.Checked)
            {
                MessageBox.Show("Otvaranje forme za javnu instituciju");
                dodatniPodaciUneti = true;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!dodatniPodaciUneti)
            {
                MessageBox.Show("Morate uneti dodatne podatke pre čuvanja!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KlijentBasic klijent = new KlijentBasic();

                klijent.ImePrezimeNaziv = txtImePrezimeNaziv.Text;
                klijent.DatumRegistracije = dtpDatumRegistracije.Value;
                klijent.StatusKlijenata = cmbStatus.SelectedItem.ToString();
                klijent.Ulica = txtUlica.Text;
                klijent.Broj = txtBroj.Text;

                klijent.Emailovi = new List<string>();
                if (!string.IsNullOrEmpty(txtEmail.Text))
                    klijent.Emailovi.Add(txtEmail.Text);

                klijent.Telefoni = new List<string>();
                if (!string.IsNullOrEmpty(txtTelefon.Text))
                    klijent.Telefoni.Add(txtTelefon.Text);

                DTOManager.dodajKlijenta(klijent);

                MessageBox.Show("Klijent uspešno sačuvan!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čuvanju: " + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
