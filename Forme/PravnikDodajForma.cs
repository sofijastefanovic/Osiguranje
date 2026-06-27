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
    public partial class PravnikDodajForma : Form
    {
        public bool DodatniPodaciUneti { get; private set; } = false;
        public string TipPravnika { get; private set; } = "";

        public PravnikDodajForma()
        {
            InitializeComponent();
            if (cmbTipPravnika.Items.Count > 0)
                cmbTipPravnika.SelectedIndex = 0;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (cmbTipPravnika.SelectedItem == null)
            {
                MessageBox.Show("Molimo izaberite tip pravnika!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TipPravnika = cmbTipPravnika.SelectedItem.ToString();
            DodatniPodaciUneti = true;

            MessageBox.Show("Podaci za pravnika su sačuvani!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void cmbTipPravnika_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
