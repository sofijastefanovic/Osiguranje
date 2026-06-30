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
                FizickoLiceDodajForma forma = new FizickoLiceDodajForma();
                forma.FormClosed += (s, args) =>
                {
                    if (forma.DodatniPodaciUneti)
                    {
                        jmbg = forma.Jmbg;
                        datumRodjenja = forma.DatumRodjenja;
                        zanimanje = forma.Zanimanje;
                        dodatniPodaciUneti = true;
                        MessageBox.Show("Dodatni podaci za fizičko lice su uneti!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                forma.ShowDialog();
            }
            else if (rbPravno.Checked)
            {
                PravnoLiceDodajForma forma = new PravnoLiceDodajForma();
                forma.FormClosed += (s, args) =>
                {
                    if (forma.DodatniPodaciUneti)
                    {
                        pib = forma.Pib;
                        maticniBroj = forma.MaticniBroj;
                        delatnost = forma.Delatnost;
                        kontaktOsobe = forma.KontaktOsobe;
                        dodatniPodaciUneti = true;
                        MessageBox.Show("Dodatni podaci za pravno lice su uneti!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                forma.ShowDialog();
            }
            else if (rbJavnaInstitucija.Checked)
            {
                JavnaInstitucijaDodajForma forma = new JavnaInstitucijaDodajForma();
                forma.FormClosed += (s, args) =>
                {
                    if (forma.DodatniPodaciUneti)
                    {
                        pibJavna = forma.Pib;
                        maticniBrojJavna = forma.MaticniBroj;
                        delatnostJavna = forma.Delatnost;
                        kontaktOsobeJavna = forma.KontaktOsobe;
                        vrstaInstitucije = forma.VrstaInstitucije;
                        dodatniPodaciUneti = true;
                        MessageBox.Show("Dodatni podaci za javnu instituciju su uneti!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                forma.ShowDialog();
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

                KlijentBasic klijent = null;  

                if (rbFizicko.Checked)
                {
                    FizickoLiceBasic fizicko = new FizickoLiceBasic();
                    fizicko.Jmbg = jmbg;
                    fizicko.DatumRodjenja = datumRodjenja;
                    fizicko.Zanimanje = zanimanje;
                    klijent = fizicko;
                }
                else if (rbPravno.Checked)
                {
                    PravnoLiceBasic pravno = new PravnoLiceBasic();
                    pravno.Pib = pib;
                    pravno.MaticniBroj = maticniBroj;
                    pravno.Delatnost = delatnost;
                    pravno.KontaktOsobe = kontaktOsobe;
                    klijent = pravno;
                }
                else if (rbJavnaInstitucija.Checked)
                {
                    JavnaInstitucijaBasic javna = new JavnaInstitucijaBasic();
                    javna.Pib = pibJavna;
                    javna.MaticniBroj = maticniBrojJavna;
                    javna.Delatnost = delatnostJavna;
                    javna.KontaktOsobe = kontaktOsobeJavna;
                    javna.VrstaInstitucije = vrstaInstitucije;
                    klijent = javna;
                }

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
