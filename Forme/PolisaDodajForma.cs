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
        private int? _bonusMalusKlasa = null;
        private string _teritorijalnoVazenje = null;
        private string _tipIsplate = null;
        private decimal? _sumaOsiguranja = null;
        private string _mrezaUstanove = null;
        private decimal? _godisnjiLimit = null;

        private int _idVlasnika = 0;
        private int _idAgenta = 0;

        public PolisaDodajForma()
        {
            InitializeComponent();
            dtpDatumZakljucenja.Value = DateTime.Now;
            UcitajKlijente();  
            UcitajAgente();
        }

        private void UcitajKlijente()
        {
            var klijenti = DTOManager.vratiSveKlijente();
            cmbVlasnik.DataSource = klijenti;
            cmbVlasnik.DisplayMember = "ImePrezimeNaziv";
            cmbVlasnik.ValueMember = "Id";
            cmbVlasnik.SelectedIndex = -1;
        }

        private void UcitajAgente()
        {
            var agenti = DTOManager.vratiSveAngazovane();
            cmbAgent.DataSource = agenti;
            cmbAgent.DisplayMember = "Ime";
            cmbAgent.ValueMember = "Id";
            cmbAgent.SelectedIndex = -1;
        }

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
                if (string.IsNullOrEmpty(txtBrojPolise.Text) || string.IsNullOrEmpty(txtOsnovnaPremija.Text))
                {
                    MessageBox.Show("Molimo popunite broj polise i osnovnu premiju pre čuvanja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Polisa novaPolisa = new Polisa();

                novaPolisa.BrojPolise = int.Parse(txtBrojPolise.Text);
                novaPolisa.DatumZakljucenja = dtpDatumZakljucenja.Value;
                novaPolisa.PeriodVazenja = int.Parse(txtPeriodVazenja.Text);
                novaPolisa.Status = txtStatus.Text;
                novaPolisa.OsnovnaPremija = decimal.Parse(txtOsnovnaPremija.Text);
                novaPolisa.Valuta = txtValuta.Text;
                novaPolisa.NacinPlacanja = txtNacinPlacanja.Text;

                novaPolisa.TipPolise = ProcitajSelektovaniTip();
                novaPolisa.TipOsiguranja = ProcitajSelektovaniTip();
 

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

        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAuto.Checked)
            {
                using (AutoOsiguranjeForma otvoriAuto = new AutoOsiguranjeForma())
                {
                    if (otvoriAuto.ShowDialog() == DialogResult.OK)  
                    {
                        _bonusMalusKlasa = otvoriAuto.Bonus;
                        _teritorijalnoVazenje = otvoriAuto.Teritorijalno;
                    }
                }
            }
        }
        private void rbZivotno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbZivotno.Checked)
            {
                using (ZivotnoOsiguranjeForma otvoriZivotno = new ZivotnoOsiguranjeForma())
                {
                    if (otvoriZivotno.ShowDialog() == DialogResult.OK)  
                    {
                        _tipIsplate = otvoriZivotno.TipIsplate;
                        _sumaOsiguranja = otvoriZivotno.SumaOsiguranja;
                    }
                }
            }
        }

        private void rbZdravstveno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbZdravstveno.Checked)
            {
                using (ZdravstvenoOsiguranjeForma otvoriZdravstvo = new ZdravstvenoOsiguranjeForma())
                {
                    if (otvoriZdravstvo.ShowDialog() == DialogResult.OK)  // DODAJ OVO!
                    {
                        _mrezaUstanove = otvoriZdravstvo.MrezaUstanove;
                        _godisnjiLimit = otvoriZdravstvo.GodisnjiLimit;
                    }
                }
            }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (rbImovinsko.Checked)
            {
                OtvoriFormuZaAtribute("imovinsko osiguranje");
            }
        }

        private void rbPoljoprivredno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPoljoprivredno.Checked)
            {
                OtvoriFormuZaAtribute("poljoprivredno osiguranje");
            }
        }
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

       // private void btnIstorijaIzmena_Click(object sender, EventArgs e)
        //{
       // }

        //private void btnDodatnoPokrice_Click(object sender, EventArgs e)
        //{
            
        //}

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
            if (string.IsNullOrEmpty(txtBrojPolise.Text))
            {
                MessageBox.Show("Unesite broj polise!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtBrojPolise.Text, out int brojPolise))
            {
                MessageBox.Show("Broj polise mora biti broj!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_idVlasnika == 0)
            {
                MessageBox.Show("Izaberite vlasnika polise!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtOsnovnaPremija.Text))
            {
                MessageBox.Show("Unesite osnovnu premiju!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtOsnovnaPremija.Text, out decimal premija))
            {
                MessageBox.Show("Osnovna premija mora biti broj!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtPeriodVazenja.Text))
            {
                MessageBox.Show("Unesite period važenja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtPeriodVazenja.Text, out int period))
            {
                MessageBox.Show("Period važenja mora biti broj!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tip = ProcitajSelektovaniTip();
            if (string.IsNullOrEmpty(tip) || tip == "Nepoznato")
            {
                MessageBox.Show("Izaberite tip polise!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                PolisaBasic polisa = null;

                switch (tip)
                {
                    case "auto osiguranje":
                        if (!_bonusMalusKlasa.HasValue || string.IsNullOrEmpty(_teritorijalnoVazenje))
                        {
                            MessageBox.Show("Unesite podatke za auto osiguranje (kliknite na 'auto osiguranje' radi dugme)!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        polisa = new AutoOsiguranjeBasic
                        {
                            BrojPolise = brojPolise,
                            DatumZakljucenja = dtpDatumZakljucenja.Value,
                            PeriodVazenja = period,
                            TipOsiguranja = tip,
                            Status = txtStatus.Text,
                            OsnovnaPremija = premija,
                            Valuta = txtValuta.Text,
                            NacinPlacanja = txtNacinPlacanja.Text,
                            TipPolise = tip,
                            IdVlasnikaPolise = _idVlasnika,
                            IdAngazovaneOsobe = _idAgenta,
                            BonusMalusKlasa = _bonusMalusKlasa.Value,
                            TeritorijalnoVazenje = _teritorijalnoVazenje
                        };
                        break;

                    case "zivotno osiguranje":
                        if (string.IsNullOrEmpty(_tipIsplate) || !_sumaOsiguranja.HasValue)
                        {
                            MessageBox.Show("Unesite podatke za životno osiguranje (kliknite na 'zivotno osiguranje' radi dugme)!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        polisa = new ZivotnoOsiguranjeBasic
                        {
                            BrojPolise = brojPolise,
                            DatumZakljucenja = dtpDatumZakljucenja.Value,
                            PeriodVazenja = period,
                            TipOsiguranja = tip,
                            Status = txtStatus.Text,
                            OsnovnaPremija = premija,
                            Valuta = txtValuta.Text,
                            NacinPlacanja = txtNacinPlacanja.Text,
                            TipPolise = tip,
                            IdVlasnikaPolise = _idVlasnika,
                            IdAngazovaneOsobe = _idAgenta,
                            TipIsplate = _tipIsplate,
                            SumaOsiguranja = _sumaOsiguranja.Value
                        };
                        break;

                    case "zdravstveno osiguranje":
                        if (string.IsNullOrEmpty(_mrezaUstanove) || !_godisnjiLimit.HasValue)
                        {
                            MessageBox.Show("Unesite podatke za zdravstveno osiguranje (kliknite na 'zdravstveno osiguranje' radi dugme)!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        polisa = new ZdravstvenoOsiguranjeBasic
                        {
                            BrojPolise = brojPolise,
                            DatumZakljucenja = dtpDatumZakljucenja.Value,
                            PeriodVazenja = period,
                            TipOsiguranja = tip,
                            Status = txtStatus.Text,
                            OsnovnaPremija = premija,
                            Valuta = txtValuta.Text,
                            NacinPlacanja = txtNacinPlacanja.Text,
                            TipPolise = tip,
                            IdVlasnikaPolise = _idVlasnika,
                            IdAngazovaneOsobe = _idAgenta,
                            MrezaUstanove = _mrezaUstanove,
                            GodisnjiLimit = _godisnjiLimit.Value
                        };
                        break;

                    default:
                        // Specijalizovano, Imovinsko, Poljoprivredno, Putno, Odgovornost
                        polisa = new PolisaBasic
                        {
                            BrojPolise = brojPolise,
                            DatumZakljucenja = dtpDatumZakljucenja.Value,
                            PeriodVazenja = period,
                            TipOsiguranja = tip,
                            Status = txtStatus.Text,
                            OsnovnaPremija = premija,
                            Valuta = txtValuta.Text,
                            NacinPlacanja = txtNacinPlacanja.Text,
                            TipPolise = tip,
                            IdVlasnikaPolise = _idVlasnika,
                            IdAngazovaneOsobe = _idAgenta
                        };
                        break;
                }

                DTOManager.dodajPolisu(polisa);
                MessageBox.Show("Polisa uspešno sačuvana!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čuvanju polise: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PolisaDodajForma_Load(object sender, EventArgs e)
        {

        }

        private void cmbVlasnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVlasnik.SelectedValue is int id)
                _idVlasnika = id;
        }

        private void cmbAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAgent.SelectedValue is int id)
                _idAgenta = id;
        }
    }
}