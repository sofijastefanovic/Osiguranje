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
    public partial class StetaDodajForma : Form
    {
        public Steta KreiranaSteta { get; private set; }

        public StetaDodajForma()
        {
            InitializeComponent();
        }

        private void txtId_TextChanged(object sender, EventArgs e) { }
        private void txtOpis_TextChanged(object sender, EventArgs e) { }
        private void txtLokacija_TextChanged(object sender, EventArgs e) { }
        private void txtStatus_TextChanged(object sender, EventArgs e) { }
        private void txtIznos_TextChanged(object sender, EventArgs e) { }


        private void rbAutoSteta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutoSteta.Checked)
            {
                if (rbAutoSteta.Checked)
                {
                    using (AutoStetaForma otvoriAuto = new AutoStetaForma())
                    {
                        otvoriAuto.ShowDialog();
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) 
        {
            if (radioButton1.Checked) 
            {
                using (ImovinskaStetaForma otvoriImovina = new ImovinskaStetaForma()) 
                { otvoriImovina.ShowDialog(); } 
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) 
        {
            if (radioButton2.Checked) 
            {
                using (ZdravstvenaStetaForm otvoriZdravstvo = new ZdravstvenaStetaForm())
                { otvoriZdravstvo.ShowDialog(); }
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!rbAutoSteta.Checked && !radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Morate izabrati vrstu štete (Auto, Životno ili Zdravstveno) pre čuvanja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtIznos.Text, out decimal procenjeniIznos))
            {
                MessageBox.Show("Molimo vas unesite ispravan procenjeni iznos štete (broj).", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string vrstaStete = "";
            if (rbAutoSteta.Checked) vrstaStete = "Auto osiguranje";
            else if (radioButton1.Checked) vrstaStete = "Životno osiguranje";
            else if (radioButton2.Checked) vrstaStete = "Zdravstveno osiguranje";

            KreiranaSteta = new Steta
            {
                Id = int.TryParse(txtId.Text, out int id) ? id : 0,

                DatumPrijave = dateTimePicker1.Value,
                DatumNastanka = dateTimePicker2.Value,

                VrstaStete = vrstaStete,
                OpisDogadjaja = txtOpis.Text,
                Lokacija = txtLokacija.Text,
                StatusPostupka = txtStatus.Text,
                ProcenjeniIznos = procenjeniIznos
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //private void btnObrisi_Click(object sender, EventArgs e)
        //{
            
        //}
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
    }
}