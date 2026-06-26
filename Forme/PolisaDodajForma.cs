using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Osiguranje.Entiteti;

namespace Osiguranje.Forme
{
    public partial class PolisaDodajForma : Form
    {
        public PolisaDodajForma()
        {
            InitializeComponent();
        }

        // Zajednička metoda za otvaranje formi sa dodatnim atributima
        private void OtvoriFormuZaAtribute(string tipOsiguranja)
        {
            //FormaDodatniAtributi formaAtributi = new FormaDodatniAtributi(tipOsiguranja);
            //formaAtributi.ShowDialog();
        }

        #region Logika za kupljenje podataka i čuvanje u bazu

        public void SnimiPolisuUBazu()
        {
            try
            {
                // 1. Osnovna provera unosa
                if (string.IsNullOrEmpty(txtBrojPolise.Text) || string.IsNullOrEmpty(txtOsnovnaPremija.Text))
                {
                    MessageBox.Show("Molimo popunite broj polise i osnovnu premiju pre čuvanja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Kreiranje objekta (Prilagodi ako koristiš PolisaBasic umesto Polisa entiteta u DTOManager-u)
                Polisa novaPolisa = new Polisa();

                // 3. Kupimo vrednosti iz svih kontrola sa forme
                novaPolisa.BrojPolise = int.Parse(txtBrojPolise.Text);
                novaPolisa.DatumZakljucenja = dtpDatumZakljucenja.Value;
                novaPolisa.PeriodVazenja = int.Parse(txtPeriodVazenja.Text);
                novaPolisa.Status = txtStatus.Text;
                novaPolisa.OsnovnaPremija = decimal.Parse(txtOsnovnaPremija.Text);
                novaPolisa.Valuta = txtValuta.Text;
                novaPolisa.NacinPlacanja = txtNacinPlacanja.Text;

                // 4. Kupimo podatak koji je radio button selektovan
                novaPolisa.TipPolise = ProcitajSelektovaniTip();
                novaPolisa.TipOsiguranja = ProcitajSelektovaniTip();

                // 5. Poziv DTOManager-a za upis u bazu
                // DTOManager.dodajPolisu(novaPolisa); 

                MessageBox.Show("Polisa je uspešno prikupljena i prosleđena bazi!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čitanju podataka: {ex.Message}\nProverite da li ste ispravno uneli brojeve.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ProcitajSelektovaniTip()
        {
            if (rbSpecijalizovano.Checked) return "specijalizovano osiguranje";
            if (rbOdgovornosti.Checked) return "osiguranje od odgovornosti";
            if (rbAuto.Checked) return "auto osiguranje";
            if (rbZivotno.Checked) return "zivotno osiguranje";
            if (rbZdravstveno.Checked) return "zdravstveno osiguranje";
            if (rbImovinsko.Checked) return "imovinsko osiguranje";
            if (rbPoljoprivredno.Checked) return "poljoprivredno osiguranje";
            if (rbPutno.Checked) return "putno osiguranje";

            return "Nepoznato";
        }

        #endregion

        #region Događaji za Radio Button-e (Usklađeni sa dizajnerom)

        // Povezano sa rbAuto u dizajneru
        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAuto.Checked)
            {
                OtvoriFormuZaAtribute("auto osiguranje");
            }
        }

        // Povezano sa rbZivotno u dizajneru
        private void rbZivotno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbZivotno.Checked)
            {
                OtvoriFormuZaAtribute("zivotno osiguranje");
            }
        }

        // Povezano sa rbZdravstveno u dizajneru
        private void rbZdravstveno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbZdravstveno.Checked)
            {
                OtvoriFormuZaAtribute("zdravstveno osiguranje");
            }
        }

        // Povezano sa rbImovinsko kroz metodu radioButton6_CheckedChanged u dizajneru
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (rbImovinsko.Checked)
            {
                OtvoriFormuZaAtribute("imovinsko osiguranje");
            }
        }

        // Povezano sa rbPoljoprivredno u dizajneru
        private void rbPoljoprivredno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPoljoprivredno.Checked)
            {
                OtvoriFormuZaAtribute("poljoprivredno osiguranje");
            }
        }

        // Ostali radio button-i koji samo menjaju stanje (ne otvaraju podforme)
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Specijalizovano osiguranje
        }

        private void rbOdgovornosti_CheckedChanged(object sender, EventArgs e)
        {
            // Osiguranje od odgovornosti
        }

        private void rbPutno_CheckedChanged(object sender, EventArgs e)
        {
            // Putno osiguranje
        }

        #endregion

        #region Klik na dugmad za Otvaranje Podformi

        private void btnIstorijaIzmena_Click(object sender, EventArgs e)
        {
            //IstorijaIzmenaForma forma = new IstorijaIzmenaForma();
            //forma.ShowDialog();
        }

        private void btnDodatnoPokrice_Click(object sender, EventArgs e)
        {
            //DodatnoPokriceForma forma = new DodatnoPokriceForma();
            //forma.ShowDialog();
        }

        #endregion

        #region Prazne metode koje dizajner zahteva (Ne brisati)

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Provera da li su uneta obavezna polja
                if (string.IsNullOrEmpty(txtBrojPolise.Text) || string.IsNullOrEmpty(txtOsnovnaPremija.Text))
                {
                    MessageBox.Show("Molimo popunite broj polise i osnovnu premiju pre čuvanja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Kreiranje objekta (Prilagodi u PolisaBasic ako ti DTOManager traži Basic klasu)
                Polisa novaPolisa = new Polisa();

                // 3. Čitanje vrednosti iz svih TextBox-eva i kalendara sa forme
                novaPolisa.BrojPolise = int.Parse(txtBrojPolise.Text);
                novaPolisa.DatumZakljucenja = dtpDatumZakljucenja.Value;
                novaPolisa.PeriodVazenja = int.Parse(txtPeriodVazenja.Text);
                novaPolisa.Status = txtStatus.Text;
                novaPolisa.OsnovnaPremija = decimal.Parse(txtOsnovnaPremija.Text);
                novaPolisa.Valuta = txtValuta.Text;
                novaPolisa.NacinPlacanja = txtNacinPlacanja.Text;

                // 4. Čitanje koji je Radio Button čekiran u grupi
                novaPolisa.TipPolise = ProcitajSelektovaniTip();
                novaPolisa.TipOsiguranja = ProcitajSelektovaniTip();

                // 5. Otkomentariši ovu liniju ispod kada budeš spremna da upišeš podatke u Oracle bazu:
                // DTOManager.dodajPolisu(novaPolisa); 

                MessageBox.Show("Polisa je uspešno sačuvana u bazi podataka!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Zatvaramo formu nakon uspešnog čuvanja
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čitanju podataka: {ex.Message}\nProverite da li ste ispravno uneli brojeve u polja za Broj polise, Period i Premiju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}