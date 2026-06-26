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
    public partial class AgentDodajForma : Form
    {
        public bool DodatniPodaciUneti { get; private set; } = false;
        public string Licensa { get; private set; } = "";
        public decimal Provizija { get; private set; } = 0;
        public string TipAgenta { get; private set; } = "";

        public AgentDodajForma()
        {
            InitializeComponent();
            if (cmbTipAgenta.Items.Count > 0)
                cmbTipAgenta.SelectedIndex = 0;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicenca.Text))
            {
                MessageBox.Show("Molimo unesite licencu!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProvizija.Text))
            {
                MessageBox.Show("Molimo unesite proviziju!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtProvizija.Text, out decimal provizija))
            {
                MessageBox.Show("Provizija mora biti broj!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Licensa = txtLicenca.Text;
            Provizija = provizija;
            TipAgenta = cmbTipAgenta.SelectedItem.ToString();
            DodatniPodaciUneti = true;

            MessageBox.Show("Podaci za agenta su sačuvani!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLicenca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProvizija_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipAgenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
