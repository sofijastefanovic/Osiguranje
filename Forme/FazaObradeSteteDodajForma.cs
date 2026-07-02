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
            UcitajStete();
        }

        private void UcitajStete()
        {
            var stete = DTOManager.vratiSveStete();
            cmbSteta.DataSource = stete;
            cmbSteta.DisplayMember = "Id";       
            cmbSteta.ValueMember = "Id";
            cmbSteta.SelectedIndex = -1;
        }

        private void txtRedniBroj_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
        private void txtOdgovornoLice_TextChanged(object sender, EventArgs e) { }
        private void txtOdluka_TextChanged(object sender, EventArgs e) { }
        private void txtDokumentacija_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {

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

            if (cmbSteta.SelectedValue == null || (int)cmbSteta.SelectedValue == 0)
            {
                MessageBox.Show("Izaberite štetu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KreiranaFaza = new FazaObradeStete
            {
                DatumPocetka = dateTimePicker1.Value,
                DatumZavrsetka = dateTimePicker2.Value,
                OdgovornoLice = txtOdgovornoLice.Text,
                Odluka = txtOdluka.Text,
                PotrebnaDokumenta = txtDokumentacija.Text,
                Steta = new Steta { Id = (int)cmbSteta.SelectedValue }
            };

            try
            {
                DTOManager.dodajFazu(KreiranaFaza);
                MessageBox.Show("Faza uspešno sačuvana!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čuvanju faze: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSteta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}