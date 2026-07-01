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
    public partial class ZivotnoOsiguranjeForma : Form
    {
        public string TipIsplate { get; private set; }
        public decimal SumaOsiguranja { get; private set; }

        public ZivotnoOsiguranje KreiranoZivotnoOsiguranje { get; private set; }

        public ZivotnoOsiguranjeForma()
        {
            InitializeComponent();
        }

        private void txtSumaOsiguranja_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtKorisniciIsplate_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTipIsplate_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtSumaOsiguranja.Text, out decimal suma))
            {
                MessageBox.Show("Molimo vas unesite ispravan iznos za sumu osiguranja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTipIsplate.Text))
            {
                MessageBox.Show("Polje za tip isplate ne sme biti prazno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TipIsplate = txtTipIsplate.Text;
            SumaOsiguranja = suma;

            KreiranoZivotnoOsiguranje = new ZivotnoOsiguranje
            {
                SumaOsiguranja = suma,
                TipIsplate = txtTipIsplate.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}