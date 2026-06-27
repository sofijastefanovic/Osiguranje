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
    public partial class ImovinskaStetaForma : Form
    {
        public ImovinskaSteta KreiranaImovinskaSteta { get; private set; }

        public ImovinskaStetaForma()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBox1.Text, out decimal iznosProcene))
            {
                MessageBox.Show("Molimo vas unesite ispravan iznos za procenu oštećenja (broj).", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            KreiranaImovinskaSteta = new ImovinskaSteta
            {
                ProcenaOstecenja = iznosProcene
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}