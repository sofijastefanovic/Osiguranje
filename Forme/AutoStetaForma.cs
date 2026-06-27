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
    public partial class AutoStetaForma : Form
    {
        public AutoSteta KreiranaAutoSteta { get; private set; }

        public AutoStetaForma()
        {
            InitializeComponent();
        }

        private void txtZapisnik_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtServis_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtZapisnik.Text))
            {
                MessageBox.Show("Molimo vas unesite broj ili napomenu za zapisnik policije.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtServis.Text))
            {
                MessageBox.Show("Polje za naziv servisa ne sme biti prazno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KreiranaAutoSteta = new AutoSteta
            {
                ZapisnikPolicije = txtZapisnik.Text,
                Servis = txtServis.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}