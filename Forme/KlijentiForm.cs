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
    public partial class KlijentiForm : Form
    {
        public KlijentiForm()
        {
            InitializeComponent();
            PostaviListView();
        }

        private void PostaviListView()
        {
            listViewKlijenti.Columns.Add("ID", 50);
            listViewKlijenti.Columns.Add("Ime/Prezime/Naziv", 180);
            listViewKlijenti.Columns.Add("Datum registracije", 120);
            listViewKlijenti.Columns.Add("Status", 100);
            listViewKlijenti.Columns.Add("Email", 150);
            listViewKlijenti.Columns.Add("Telefon", 100);
            listViewKlijenti.Columns.Add("Ulica", 150);
            listViewKlijenti.Columns.Add("Broj", 60);

            listViewKlijenti.View = View.Details;
            listViewKlijenti.FullRowSelect = true;
            listViewKlijenti.GridLines = true;
        }

        private void KlijentiForm_Load(object sender, EventArgs e)
        {
            OsveziListu();
        }

        private void OsveziListu()
        {
            listViewKlijenti.Items.Clear();
            // KASNIJE: DTOManager.vratiSveKlijente()
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listViewKlijenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KlijentDodajForm forma = new KlijentDodajForm();
            forma.ShowDialog();
            OsveziListu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewKlijenti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite klijenta za brisanje!");
                return;
            }

            DialogResult result = MessageBox.Show("Da li ste sigurni?", "Brisanje", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = int.Parse(listViewKlijenti.SelectedItems[0].SubItems[0].Text);
                // DTOManager.obrisiKlijenta(id); // KASNIJE
                OsveziListu();
            }
        }
    }
}
