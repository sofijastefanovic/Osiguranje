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
    public partial class FazaObradeSteteDodajForma : Form
    {
        public FazaObradeStete KreiranaFaza { get; private set; }

        public FazaObradeSteteDodajForma()
        {
            InitializeComponent();
        }

        private void txtRedniBroj_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
        private void txtOdgovornoLice_TextChanged(object sender, EventArgs e) { }
        private void txtOdluka_TextChanged(object sender, EventArgs e) { }
        private void txtDokumentacija_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRedniBroj.Text, out int rbFaze))
            {
                MessageBox.Show("Molimo vas unesite ispravan redni broj faze.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOdgovornoLice.Text))
            {
                MessageBox.Show("Polje za odgovorno lice ne sme biti prazno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("Datum završetka faze ne može biti pre datuma početka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KreiranaFaza = new FazaObradeStete
            {
                RedniBrojFaze = rbFaze,
                DatumPocetka = dateTimePicker1.Value,
                DatumZavrsetka = dateTimePicker2.Value,
                OdgovornoLice = txtOdgovornoLice.Text,
                Odluka = txtOdluka.Text,
                PotrebnaDokumenta = txtDokumentacija.Text

            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}