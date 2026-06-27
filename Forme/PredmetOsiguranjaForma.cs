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
    public partial class PredmetOsiguranjaForma : Form
    {
        public PredmetOsiguranjaForma()
        {
            InitializeComponent();
            PostaviListView();
        }

        private void PostaviListView()
        {
            listViewPredmetiOsiguranja.Columns.Clear();
            listViewPredmetiOsiguranja.Columns.Add("ID", 50);
            listViewPredmetiOsiguranja.Columns.Add("Tip predmeta", 200);

            listViewPredmetiOsiguranja.View = View.Details;
            listViewPredmetiOsiguranja.FullRowSelect = true;
            listViewPredmetiOsiguranja.GridLines = true;
        }

        private void PredmetForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            try
            {
                listViewPredmetiOsiguranja.Items.Clear();

                var predmeti = DTOManager.vratiSvePredmete();

                foreach (var p in predmeti)
                {
                    ListViewItem item = new ListViewItem(new string[] {
                        p.Id.ToString(),
                        p.TipPredmeta
                    });
                    listViewPredmetiOsiguranja.Items.Add(item);
                }

                listViewPredmetiOsiguranja.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                foreach (ColumnHeader kolona in listViewPredmetiOsiguranja.Columns)
                {
                    int sirinaSadrzaja = kolona.Width;
                    kolona.Width = -2;
                    if (sirinaSadrzaja > kolona.Width)
                        kolona.Width = sirinaSadrzaja;
                }

                listViewPredmetiOsiguranja.Refresh();
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewPredmetiOsiguranja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite predmet za brisanje!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj predmet?",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = int.Parse(listViewPredmetiOsiguranja.SelectedItems[0].SubItems[0].Text);
                DTOManager.obrisiPredmet(id);
                popuniPodacima();
                MessageBox.Show("Predmet uspešno obrisan!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDODAJ_Click(object sender, EventArgs e)
        {
            PredmetOsiguranjaDodajForma forma = new PredmetOsiguranjaDodajForma();
            forma.FormClosed += (s, args) => popuniPodacima();
            forma.ShowDialog();
        }

        private void listViewPredmetiOsiguranja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

