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
    public partial class PutovanjeDodajForma : Form
    {
        public bool DodatniPodaciUneti { get; private set; } = false;
        public int PeriodPutovanja { get; private set; } = 0;

        public PutovanjeDodajForma()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPeriodPutovanja.Text))
            {
                MessageBox.Show("Molimo unesite period putovanja!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtPeriodPutovanja.Text, out int period))
            {
                MessageBox.Show("Period putovanja mora biti broj!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (period <= 0)
            {
                MessageBox.Show("Period putovanja mora biti veći od 0!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PeriodPutovanja = period;
            DodatniPodaciUneti = true;

            MessageBox.Show("Podaci za putovanje su sačuvani!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPeriodPutovanja_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
