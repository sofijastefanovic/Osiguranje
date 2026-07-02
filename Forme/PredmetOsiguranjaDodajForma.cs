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
    public partial class PredmetOsiguranjaDodajForma : Form
    {
        private bool dodatniPodaciUneti = false;

        private string registracija = "";
        private string marka = "";
        private string model = "";
        private int godinaProizvodnje = 0;
        private string imeVlasnika = "";
        private string prezimeVlasnika = "";
        private int brojPoliseAuto = 0;

        private string jmbg = "";
        private string ime = "";
        private string prezime = "";
        private DateTime datumRodjenja = DateTime.Now;

        private string adresa = "";
        private string tipObjekta = "";
        private int godinaIzgradnje = 0;
        private decimal povrsina = 0;
        private decimal procenjenaVrednost = 0;

        private string serijskiBroj = "";
        private string naziv = "";
        private string opis = "";
        private decimal procenjenaVrednostPokretna = 0;

        private string vrstaUseva = "";
        private string lokacijaUseva = "";
        private decimal procenjenaVrednostUseva = 0;

        private string vrstaZivotinje = "";
        private string lokacijaZivotinje = "";
        private decimal procenjenaVrednostZivotinje = 0;

        private string opisOdgovornosti = "";

        private int periodPutovanja = 0;
        public PredmetOsiguranjaDodajForma()
        {
            InitializeComponent();
            cmbTipPredmeta.SelectedIndex = 0;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
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
                string tip = cmbTipPredmeta.SelectedItem.ToString();
                PredmetOsiguranjaBasic predmet = null;

                switch (tip)
                {
                    case "Vozilo":
                        predmet = new VoziloBasic
                        {
                            TipPredmeta = tip,
                            Registracija = registracija,
                            Marka = marka,
                            Model = model,
                            GodinaProizvodnje = godinaProizvodnje,
                            ImeVlasnika = imeVlasnika,
                            PrezimeVlasnika = prezimeVlasnika,
                            BrojPoliseAuto = brojPoliseAuto
                        };
                        break;

                    case "Lice":
                        predmet = new LiceBasic
                        {
                            TipPredmeta = tip,
                            Jmbg = jmbg,
                            Ime = ime,
                            Prezime = prezime,
                            DatumRodjenja = datumRodjenja
                        };
                        break;

                    case "Nekretnina":
                        predmet = new NekretninaBasic
                        {
                            TipPredmeta = tip,
                            Adresa = adresa,
                            TipObjekta = tipObjekta,
                            GodinaIzgradnje = godinaIzgradnje,
                            Povrsina = povrsina,
                            ProcenjenaVrednost = procenjenaVrednost
                        };
                        break;

                    case "Pokretna imovina":
                        predmet = new PokretnaImovinaBasic
                        {
                            TipPredmeta = tip,
                            SerijskiBroj = serijskiBroj,
                            Naziv = naziv,
                            Opis = opis,
                            ProcenjenaVrednost = procenjenaVrednostPokretna
                        };
                        break;

                    case "Usev":
                        predmet = new UsevBasic
                        {
                            TipPredmeta = tip,
                            Vrsta = vrstaUseva,
                            Lokacija = lokacijaUseva,
                            ProcenjenaVrednost = procenjenaVrednostUseva
                        };
                        break;

                    case "Životinja":
                        predmet = new ZivotinjaBasic
                        {
                            TipPredmeta = tip,
                            Vrsta = vrstaZivotinje,
                            Lokacija = lokacijaZivotinje,
                            ProcenjenaVrednost = procenjenaVrednostZivotinje
                        };
                        break;

                    case "Odgovornost":
                        predmet = new OdgovornostBasic
                        {
                            TipPredmeta = tip,
                            Opis = opisOdgovornosti
                        };
                        break;

                    case "Putovanje":
                        predmet = new PutovanjeBasic
                        {
                            TipPredmeta = tip,
                            PeriodPutovanja = periodPutovanja
                        };
                        break;

                    default:
                        predmet = new PredmetOsiguranjaBasic
                        {
                            TipPredmeta = tip
                        };
                        break;
                }

                DTOManager.dodajPredmet(predmet);
                MessageBox.Show("Predmet uspešno sačuvan!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čuvanju: " + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodatniPodaci_Click(object sender, EventArgs e)
        {
            string tip = cmbTipPredmeta.SelectedItem.ToString();

            if (tip == "Vozilo")
            {
                VoziloDodajForma forma = new VoziloDodajForma();
                forma.FormClosed += (s, args) =>
                {
                    if (forma.DodatniPodaciUneti)
                    {
                        registracija = forma.Registracija;
                        marka = forma.Marka;
                        model = forma.Model;
                        godinaProizvodnje = forma.GodinaProizvodnje;
                        imeVlasnika = forma.ImeVlasnika;
                        prezimeVlasnika = forma.PrezimeVlasnika;
                        dodatniPodaciUneti = true;
                        MessageBox.Show("Podaci za vozilo su uneti!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                forma.ShowDialog();
            }
            else if (tip == "Lice")
            {
                LiceDodajForma forma = new LiceDodajForma();
                forma.FormClosed += (s, args) =>
                {
                    if (forma.DodatniPodaciUneti)
                    {
                        jmbg = forma.Jmbg;
                        ime = forma.Ime;
                        prezime = forma.Prezime;
                        datumRodjenja = forma.DatumRodjenja;
                        dodatniPodaciUneti = true;
                        MessageBox.Show("Podaci za lice su uneti!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                forma.ShowDialog();
            }
            else if (tip == "Nekretnina")
            {
                NekretninaDodajForma forma = new NekretninaDodajForma();
                forma.FormClosed += (s, args) =>
                {
                    if (forma.DodatniPodaciUneti)
                    {
                        adresa = forma.Adresa;
                        tipObjekta = forma.TipObjekta;
                        godinaIzgradnje = forma.GodinaIzgradnje;
                        povrsina = forma.Povrsina;
                        procenjenaVrednost = forma.ProcenjenaVrednost;
                        dodatniPodaciUneti = true;
                        MessageBox.Show("Podaci za nekretninu su uneti!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                forma.ShowDialog();
            }
            else if (tip == "Pokretna imovina")
            {
                PokretnaImovinaDodajForma forma = new PokretnaImovinaDodajForma();
                forma.FormClosed += (s, args) =>
                {
                    if (forma.DodatniPodaciUneti)
                    {
                        serijskiBroj = forma.SerijskiBroj;
                        naziv = forma.Naziv;
                        opis = forma.Opis;
                        procenjenaVrednostPokretna = forma.ProcenjenaVrednost;
                        dodatniPodaciUneti = true;
                        MessageBox.Show("Podaci za pokretnu imovinu su uneti!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                forma.ShowDialog();
            }
            else if (tip == "Usev")
            {
                UsevDodajForma forma = new UsevDodajForma();
                forma.FormClosed += (s, args) =>
                {
                    if (forma.DodatniPodaciUneti)
                    {
                        vrstaUseva = forma.Vrsta;
                        lokacijaUseva = forma.Lokacija;
                        procenjenaVrednostUseva = forma.ProcenjenaVrednost;
                        dodatniPodaciUneti = true;
                        MessageBox.Show("Podaci za usev su uneti!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                forma.ShowDialog();
            }
            else if (tip == "Životinja")
            {
                ZivotinjaDodajForma forma = new ZivotinjaDodajForma();
                forma.FormClosed += (s, args) =>
                {
                    if (forma.DodatniPodaciUneti)
                    {
                        vrstaZivotinje = forma.Vrsta;
                        lokacijaZivotinje = forma.Lokacija;
                        procenjenaVrednostZivotinje = forma.ProcenjenaVrednost;
                        dodatniPodaciUneti = true;
                        MessageBox.Show("Podaci za zivotinju su uneti!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                forma.ShowDialog();
            }
            else if (tip == "Odgovornost")
            {
                OdgovornostDodajForma forma = new OdgovornostDodajForma();
                forma.FormClosed += (s, args) =>
                {
                    if (forma.DodatniPodaciUneti)
                    {
                        opisOdgovornosti = forma.Opis;
                        dodatniPodaciUneti = true;
                        MessageBox.Show("Podaci za odgovornost su uneti!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                forma.ShowDialog();
            }
            else if (tip == "Putovanje")
            {
                PutovanjeDodajForma forma = new PutovanjeDodajForma();
                forma.FormClosed += (s, args) =>
                {
                    if (forma.DodatniPodaciUneti)
                    {
                        periodPutovanja = forma.PeriodPutovanja;
                        dodatniPodaciUneti = true;
                        MessageBox.Show("Podaci za putovanje su uneti!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                forma.ShowDialog();
            }
        }

        private void cmbTipPredmeta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
