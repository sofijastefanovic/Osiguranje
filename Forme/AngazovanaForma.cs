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
    public partial class AngazovanaForma : Form
    {
        public AngazovanaForma()
        {
            InitializeComponent();
            PostaviListView();
        }

        private void PostaviListView()
        {
            listViewAngazovani.Columns.Clear();

            listViewAngazovani.Columns.Add("ID", 50);
            listViewAngazovani.Columns.Add("Ime", 120);
            listViewAngazovani.Columns.Add("Prezime", 120);
            listViewAngazovani.Columns.Add("Kontakt", 150);
            listViewAngazovani.Columns.Add("Datum angažovanja", 130);
            listViewAngazovani.Columns.Add("Status", 100);
            listViewAngazovani.Columns.Add("Tip osobe", 130);

            listViewAngazovani.View = View.Details;
            listViewAngazovani.FullRowSelect = true;
            listViewAngazovani.GridLines = true;
        }

        private void AngazovanaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            try
            {
                listViewAngazovani.Items.Clear();

                var osobe = DTOManager.vratiSveAngazovane();

                foreach (var o in osobe)
                {
                    ListViewItem item = new ListViewItem(new string[] {
                        o.Id.ToString(),
                        o.Ime,
                        o.Prezime,
                        o.Kontakt,
                        o.DatumAngazovanja.ToShortDateString(),
                        o.Status,
                        o.TipOsobe
                    });
                    listViewAngazovani.Items.Add(item);
                }

                listViewAngazovani.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                foreach (ColumnHeader kolona in listViewAngazovani.Columns)
                {
                    int sirinaSadrzaja = kolona.Width;
                    kolona.Width = -2;
                    if (sirinaSadrzaja > kolona.Width)
                        kolona.Width = sirinaSadrzaja;
                }

                listViewAngazovani.Refresh();
            }
            catch (Exception ex)
            {
                Exception stvarnaGreska = ex;
                while (stvarnaGreska.InnerException != null)
                    stvarnaGreska = stvarnaGreska.InnerException;

                MessageBox.Show($"PRAVI UZROK GREŠKE:\n\n{stvarnaGreska.Message}",
                                "NHibernate Detalji",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            AngazovanaDodajForma forma = new AngazovanaDodajForma();
            forma.FormClosed += (s, args) => popuniPodacima();
            forma.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewAngazovani.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite osobu za brisanje!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete ovu osobu?",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = int.Parse(listViewAngazovani.SelectedItems[0].SubItems[0].Text);
                DTOManager.obrisiAngazovanu(id);
                popuniPodacima();
                MessageBox.Show("Osoba uspešno obrisana!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listViewAngazovani_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
     }
}
