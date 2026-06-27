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
        }

        private void txtMetodProcene_TextChanged(object sender, EventArgs e) { }
        private void txtNalaz_TextChanged(object sender, EventArgs e) { }
        private void txtPreporuka_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrWhiteSpace(txtMetodProcene.Text))
            {
                MessageBox.Show("Polje za metod procene ne sme biti prazno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KreiranaProcena = new Procena
            {
                DatumProcene = dateTimePicker1.Value,
                MetodProcene = txtMetodProcene.Text,
                Nalaz = txtNalaz.Text,
                Preporuka = txtPreporuka.Text,
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}