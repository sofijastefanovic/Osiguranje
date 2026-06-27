using System;
using System.Windows.Forms;
using NHibernate;
using Osiguranje.Entiteti;

namespace Osiguranje.Forme
{
    public partial class IstorijaIzmenaPolisaForma : Form
    {
        // Lokalna promenljiva koja pamti polisu koju menjamo
        private Polisa _polisa;

        // Modifikovan konstruktor koji prima izabranu polisu
        public IstorijaIzmenaPolisaForma(Polisa izabranaPolisa)
        {
            InitializeComponent();
            this._polisa = izabranaPolisa;

            // Opciono: Postavi inicijalne vrednosti ako želiš pri otvaranju forme
            if (_polisa != null)
            {
                // txtStaraVrednost.Text = $"Stara premija: {_polisa.OsnovnaPremija}";
            }
        }

        // Pretpostavljam da je button1 u stvari dugme "Sačuvaj izmenu"
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Validacija unosa
            if (string.IsNullOrEmpty(txtTipIzmene.Text) || string.IsNullOrEmpty(txtNovaVrednost.Text))
            {
                MessageBox.Show("Molimo vas da popunite tip izmene i novu vrednost!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Kreiranje novog objekta istorije izmena
                IstorijaIzmenaPolisa novaIzmena = new IstorijaIzmenaPolisa
                {
                    TipIzmene = txtTipIzmene.Text,
                    StaraVrednost = txtStaraVrednost.Text,
                    NovaVrednost = txtNovaVrednost.Text,
                    DatumIzmene = dateTimePicker1.Value,
                    Polisa = this._polisa // Povezujemo istoriju sa prosleđenom polisom
                };

                // 3. Čuvanje u bazu podataka preko NHibernate-a
                using (ISession session = DataLayer.GetSession())
                {
                    using (ITransaction tx = session.BeginTransaction())
                    {
                        // Pošto je u bazi Polisa glavni entitet, a istorija zavisi od nje,
                        // čuvamo direktno zapis istorije
                        session.Save(novaIzmena);
                        tx.Commit();
                    }
                }

                MessageBox.Show("Izmena polise je uspešno zabeležena u istoriji!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK; // Javlja glavnoj formi da je sve prošlo uspešno
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čuvanju izmene: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Prazne metode koje dizajner zahteva (Ne brisati)

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            // ID obično generiše baza (TriggerIdentity), pa je ovo polje uglavnom ReadOnly
        }

        private void txtNovaVrednost_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtStaraVrednost_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTipIzmene_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        #endregion
    }
}