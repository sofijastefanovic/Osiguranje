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
    public partial class ZdravstvenoOsiguranjeForma : Form
    {
        public string MrezaUstanove { get; private set; }
        public decimal GodisnjiLimit { get; private set; }

        public ZdravstvenoOsiguranje KreiranoZdravstvenoOsiguranje { get; private set; }

        public ZdravstvenoOsiguranjeForma()
        {
            InitializeComponent();
        }

        private void txtMreza_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtObuhvacena_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtGodisnji_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtGodisnji.Text, out decimal limit))
            {
                MessageBox.Show("Molimo vas unesite ispravan iznos za godišnji limit.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMreza.Text))
            {
                MessageBox.Show("Polje za mrežu ustanove ne sme biti prazno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MrezaUstanove = txtMreza.Text;
            GodisnjiLimit = limit;

            KreiranoZdravstvenoOsiguranje = new ZdravstvenoOsiguranje
            {
                MrezaUstanove = txtMreza.Text,
                GodisnjiLimit = limit
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}