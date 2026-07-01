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
    public partial class ProcenaDodajForma : Form
    {
        public Procena KreiranaProcena { get; private set; }

        public ProcenaDodajForma()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            UcitajStete();
            UcitajAngazovaneOsobe();
        }

        private void UcitajStete()
        {
            var stete = DTOManager.vratiSveStete();
            cmbSteta.DataSource = stete;
            cmbSteta.DisplayMember = "Id";
            cmbSteta.ValueMember = "Id";
            cmbSteta.SelectedIndex = -1;
        }

        private void UcitajAngazovaneOsobe()
        {
            var osobe = DTOManager.vratiSveAngazovane();
            cmbAngazovanaOsoba.DataSource = osobe;
            cmbAngazovanaOsoba.DisplayMember = "Ime";
            cmbAngazovanaOsoba.ValueMember = "Id";
            cmbAngazovanaOsoba.SelectedIndex = -1;
        }

        private void txtMetodProcene_TextChanged(object sender, EventArgs e) { }
        private void txtNalaz_TextChanged(object sender, EventArgs e) { }
        private void txtPreporuka_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            // Validacija
            if (string.IsNullOrWhiteSpace(txtMetodProcene.Text))
            {
                MessageBox.Show("Unesite metod procene!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSteta.SelectedValue == null || (int)cmbSteta.SelectedValue == 0)
            {
                MessageBox.Show("Izaberite štetu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbAngazovanaOsoba.SelectedValue == null || (int)cmbAngazovanaOsoba.SelectedValue == 0)
            {
                MessageBox.Show("Izaberite angažovanu osobu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtProcenjeniIznos.Text, out decimal iznos))
            {
                MessageBox.Show("Procenjeni iznos mora biti broj!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Procena novaProcena = new Procena();
                novaProcena.Id = new ProcenaId();
                novaProcena.Id.Steta = new Steta { Id = (int)cmbSteta.SelectedValue };
                novaProcena.Id.AngazovanaOsoba = new AngazovanaOsoba { Id = (int)cmbAngazovanaOsoba.SelectedValue };
                novaProcena.DatumProcene = dateTimePicker1.Value;
                novaProcena.MetodProcene = txtMetodProcene.Text;
                novaProcena.Nalaz = txtNalaz.Text;
                novaProcena.Preporuka = txtPreporuka.Text;
                novaProcena.ProcenjeniIznos = iznos;

                DTOManager.dodajProceni(novaProcena);
                MessageBox.Show("Procena uspešno sačuvana!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbSteta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAngazovanaOsoba_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProcenjeniIznos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}