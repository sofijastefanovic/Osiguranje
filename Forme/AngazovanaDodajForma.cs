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
    public partial class AngazovanaDodajForma : Form
    {
        public bool DodatniPodaciUneti { get; private set; } = false;

        private string licensaAgenta = "";
        private decimal provizija = 0;
        private string tipAgenta = "";

        private string licensaProcenitelja = "";
        private string tipProcenitelja = "";

        private string tipPravnika = "";
        public AngazovanaDodajForma()
        {
            InitializeComponent();
            dtpDatumAngazovanja.Value = DateTime.Now;
            cmbStatus.SelectedIndex = 0;
            cmbTipOsobe.SelectedIndex = 0;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!DodatniPodaciUneti)
            {
                MessageBox.Show("Morate uneti dodatne podatke pre čuvanja!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AngazovanaOsobaBasic osoba = new AngazovanaOsobaBasic();

                osoba.Ime = txtIme.Text;
                osoba.Prezime = txtPrezime.Text;
                osoba.Kontakt = txtKontakt.Text;
                osoba.DatumAngazovanja = dtpDatumAngazovanja.Value;
                osoba.Status = cmbStatus.SelectedItem.ToString();
                osoba.TipOsobe = cmbTipOsobe.SelectedItem.ToString();

                DTOManager.dodajAngazovanu(osoba);

                MessageBox.Show("Angažovana osoba uspešno sačuvana!", "Info",
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

        private void btnDodatniPodaci_Click(object sender, EventArgs e)
        {
            string tip = cmbTipOsobe.SelectedItem.ToString();

            if (tip == "Agent")
            {
                AgentDodajForma forma = new AgentDodajForma();
                forma.FormClosed += (s, args) =>
                {
                    if (forma.DodatniPodaciUneti)
                    {
                        licensaAgenta = forma.Licensa;
                        provizija = forma.Provizija;
                        tipAgenta = forma.TipAgenta;
                        DodatniPodaciUneti = true;
                        MessageBox.Show("Podaci za agenta su uneti!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                forma.ShowDialog();
            }
            else if (tip == "Procenitelj")
            {
                ProceniteljDodajForma forma = new ProceniteljDodajForma();
                forma.FormClosed += (s, args) =>
                {
                    if (forma.DodatniPodaciUneti)
                    {
                        licensaProcenitelja = forma.Licensa;
                        tipProcenitelja = forma.TipProcenitelja;
                        DodatniPodaciUneti = true;
                        MessageBox.Show("Podaci za procenitelja su uneti!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                forma.ShowDialog();
            }
            else if (tip == "Pravnik")
            {
                PravnikDodajForma forma = new PravnikDodajForma();
                forma.FormClosed += (s, args) =>
                {
                    if (forma.DodatniPodaciUneti)
                    {
                        tipPravnika = forma.TipPravnika;
                        DodatniPodaciUneti = true;
                        MessageBox.Show("Podaci za pravnika su uneti!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                forma.ShowDialog();
            }
            else if (tip == "Lekar konsultant")
            {
                DodatniPodaciUneti = true;
                MessageBox.Show("Lekar konsultant nema dodatnih podataka!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbTipOsobe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDatumAngazovanja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtKontakt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
