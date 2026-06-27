using System;
using System.Windows.Forms;

namespace Osiguranje.Forme
{
    public partial class AutoOsiguranjeForma : Form
    {
        public int Bonus { get; private set; }
        public string Teritorijalno { get; private set; }

        public AutoOsiguranjeForma()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBonus.Text) || string.IsNullOrEmpty(txtTeritorijalno.Text))
            {
                MessageBox.Show("Molimo vas da popunite sva polja za auto osiguranje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtBonus.Text, out int parsedBonus))
            {
                MessageBox.Show("Polje 'Bonus' mora biti uneto kao ceo broj!", "Greška u unosu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Bonus = parsedBonus;
            this.Teritorijalno = txtTeritorijalno.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #region Prazne metode koje dizajner zahteva (Ne brisati)

        private void txtVozaci_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBonus_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTeritorijalno_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion
    }
}