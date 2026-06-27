using System;
using System.Linq;
using System.Windows.Forms;
using NHibernate;
using Osiguranje.Entiteti;

namespace Osiguranje.Forme
{
    public partial class DodatnoPokriceForma : Form
    {
        // Lokalna promenljiva koja čuva referencu na polisu za koju dodajemo pokriće
        private Polisa _polisa;
        private int _sledeciRedniBroj = 1;

        // Modifikovan konstruktor koji prima selektovanu polisu
        public DodatnoPokriceForma(Polisa izabranaPolisa)
        {
            InitializeComponent();
            this._polisa = izabranaPolisa;

            if (_polisa != null)
            {
                IzracunajSledeciRedniBroj();
            }
        }

        private void IzracunajSledeciRedniBroj()
        {
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    // Vučemo sva postojeća pokrića za ovu konkretnu polisu iz baze
                    var postojecaPokrica = session.QueryOver<DodatnoPokrice>()
                                                  .Where(x => x.Polisa.BrojPolise == _polisa.BrojPolise)
                                                  .List();

                    // Ako već postoje pokrića, sledeći broj je Max + 1, u suprotnom je 1
                    if (postojecaPokrica.Count > 0)
                    {
                        _sledeciRedniBroj = postojecaPokrica.Max(x => x.RedniBroj) + 1;
                    }
                    else
                    {
                        _sledeciRedniBroj = 1;
                    }

                    // Prikazujemo izračunati redni broj u TextBox-u i stavljamo da bude ReadOnly
                    txtRedniBroj.Text = _sledeciRedniBroj.ToString();
                    txtRedniBroj.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri računanju rednog broja: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                MessageBox.Show("Molimo vas da unesete naziv dodatnog pokrića.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtLimit.Text, out decimal limit) ||
                !decimal.TryParse(txtFransiza.Text, out decimal fransiza) ||
                !decimal.TryParse(txtDodatnaPremija.Text, out decimal dodatnaPremija))
            {
                MessageBox.Show("Polja Limit, Franšiza i Dodatna premija moraju biti ispravni brojevi!", "Greška u unosu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DodatnoPokrice novoPokrice = new DodatnoPokrice
                {
                    Polisa = this._polisa,
                    RedniBroj = this._sledeciRedniBroj,
                    Naziv = txtNaziv.Text,
                    Opis = txtOpis.Text,
                    Limit = limit,
                    Fransiza = fransiza,
                    DodatnaPremija = dodatnaPremija
                };

                using (ISession session = DataLayer.GetSession())
                {
                    using (ITransaction tx = session.BeginTransaction())
                    {
                        session.Save(novoPokrice);
                        tx.Commit();
                    }
                }

                MessageBox.Show("Dodatno pokriće je uspešno sačuvano za izabranu polisu!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čuvanju dodatnog pokrića: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Prazne metode koje dizajner zahteva (Ne brisati)

        private void txtRedniBroj_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtOpis_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtLimit_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtFransiza_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDodatnaPremija_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private void DodatnoPokriceForma_Load(object sender, EventArgs e)
        {

        }
    }
}