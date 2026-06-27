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
    public partial class ZdravstvenaStetaForm : Form
    {
        public ZdravstvenaSteta KreiranaZdravstvenaSteta { get; private set; }

        public ZdravstvenaStetaForm()
        {
            InitializeComponent();
        }

        private void txtDokumenta_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUstanova_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDokumenta.Text))
            {
                MessageBox.Show("Molimo vas unesite spisak ili napomenu za zdravstvenu dokumentaciju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUstanova.Text))
            {
                MessageBox.Show("Polje za zdravstvenu ustanovu ne sme biti prazno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KreiranaZdravstvenaSteta = new ZdravstvenaSteta
            {
                ZdravstvenaDokumenta = txtDokumenta.Text,
                ZdravstvenaUstanova = txtUstanova.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}