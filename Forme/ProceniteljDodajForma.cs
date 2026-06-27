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
    public partial class ProceniteljDodajForma : Form
    {
        public bool DodatniPodaciUneti { get; private set; } = false;
        public string Licensa { get; private set; } = "";
        public string TipProcenitelja { get; private set; } = "";


        public ProceniteljDodajForma()
        {
            InitializeComponent();
            if (cmbTipProcenitelja.Items.Count > 0)
                cmbTipProcenitelja.SelectedIndex = 0;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicenca.Text))
            {
                MessageBox.Show("Molimo unesite licencu!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Licensa = txtLicenca.Text;
            TipProcenitelja = cmbTipProcenitelja.SelectedItem.ToString();
            DodatniPodaciUneti = true;

            MessageBox.Show("Podaci za procenitelja su sačuvani!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipProcenitelja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLicenca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
