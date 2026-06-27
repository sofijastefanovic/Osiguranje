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
    public partial class OdgovornostDodajForma : Form
    {
        public bool DodatniPodaciUneti { get; private set; } = false;
        public string Opis { get; private set; } = "";

        public OdgovornostDodajForma()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                MessageBox.Show("Molimo unesite opis!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Opis = txtOpis.Text;
            DodatniPodaciUneti = true;

            MessageBox.Show("Podaci za odgovornost su sačuvani!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOpis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
