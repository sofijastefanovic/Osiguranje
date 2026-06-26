using System;
using System.Windows.Forms;

namespace Osiguranje.Forme
{
    public partial class KlijentForma : Form
    {
        public KlijentForma()
        {
            InitializeComponent();
        }

        private void KlijentForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            try
            {
                listViewKlijenti.Items.Clear();

                var klijenti = DTOManager.vratiSveKlijente();

                foreach (var k in klijenti)
                {
                    ListViewItem item = new ListViewItem(new string[] {
                        k.Id.ToString(),
                        k.ImePrezimeNaziv,
                        k.DatumRegistracije.ToShortDateString(),
                        k.StatusKlijenata,
                        k.Email,
                        k.Telefon,
                        k.Ulica,
                        k.Broj
                    });
                    listViewKlijenti.Items.Add(item);
                }

                listViewKlijenti.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                foreach (ColumnHeader kolona in listViewKlijenti.Columns)
                {
                    int sirinaSadrzaja = kolona.Width;
                    kolona.Width = -2;

                    if (sirinaSadrzaja > kolona.Width)
                    {
                        kolona.Width = sirinaSadrzaja;
                    }
                }

                listViewKlijenti.Refresh();
            }
            catch (Exception ex)
            {
                Exception stvarnaGreska = ex;
                while (stvarnaGreska.InnerException != null)
                {
                    stvarnaGreska = stvarnaGreska.InnerException;
                }

                MessageBox.Show($"PRAVI UZROK GREŠKE:\n\n{stvarnaGreska.Message}",
                                "NHibernate Detalji",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KlijentiDodajForma forma = new KlijentiDodajForma();
            forma.FormClosed += (s, args) =>
            {
                popuniPodacima();
            };
            forma.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewKlijenti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite klijenta za brisanje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete ovog klijenta?",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = int.Parse(listViewKlijenti.SelectedItems[0].SubItems[0].Text);
                DTOManager.obrisiKlijenta(id);
                popuniPodacima();
                MessageBox.Show("Klijent uspešno obrisan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}