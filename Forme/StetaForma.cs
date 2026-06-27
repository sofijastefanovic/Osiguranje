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
using NHibernate;        

namespace Osiguranje.Forme
{
    public partial class StetaForma : Form
    {
        public StetaForma()
        {
            InitializeComponent();
            InicijalizujTabelu();
            UcitajSteteIzBaze();
        }
        private void InicijalizujTabelu()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Scrollable = true;

            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Vrsta Štete", 120);
            listView1.Columns.Add("Datum Prijave", 100);
            listView1.Columns.Add("Datum Nastanka", 100);
            listView1.Columns.Add("Lokacija", 120);
            listView1.Columns.Add("Status Postupka", 110);
            listView1.Columns.Add("Procenjeni Iznos", 110);
            listView1.Columns.Add("Oštećeno Lice", 150);
            listView1.Columns.Add("Opis Događaja", 200);
        }

        private void UcitajSteteIzBaze()
        {
            listView1.Items.Clear();

            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IList<Steta> sveStete = session.QueryOver<Steta>().List();

                    foreach (Steta s in sveStete)
                    {
                        ListViewItem red = new ListViewItem(s.Id.ToString());

                        red.SubItems.Add(s.VrstaStete ?? "N/A");
                        red.SubItems.Add(s.DatumPrijave.ToString("dd.MM.yyyy"));
                        red.SubItems.Add(s.DatumNastanka.ToString("dd.MM.yyyy"));
                        red.SubItems.Add(s.Lokacija ?? "N/A");
                        red.SubItems.Add(s.StatusPostupka ?? "U obradi");
                        red.SubItems.Add(s.ProcenjeniIznos.ToString("N2") + " RSD");

                        string klijentInfo = s.OstecenoLice != null ? s.OstecenoLice.ImePrezimeNaziv : "Nepoznato";
                        red.SubItems.Add(klijentInfo);

                        red.SubItems.Add(s.OpisDogadjaja ?? "");

                        red.Tag = s;

                        listView1.Items.Add(red);
                    }
                }

                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                foreach (ColumnHeader kolona in listView1.Columns)
                {
                    int sirinaSadrzaja = kolona.Width;
                    kolona.Width = -2; 

                    if (sirinaSadrzaja > kolona.Width)
                    {
                        kolona.Width = sirinaSadrzaja;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri komunikaciji sa bazom: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (StetaDodajForma otvoriDodaj = new StetaDodajForma())
            {
                if (otvoriDodaj.ShowDialog() == DialogResult.OK)
                {
                    UcitajSteteIzBaze();
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete štetu iz liste koju želite da obrišete.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selektovaniRed = listView1.SelectedItems[0];
            Steta izabranaSteta = (Steta)selektovaniRed.Tag;

            DialogResult potvrda = MessageBox.Show(
                $"Da li ste sigurni da želite da obrišete prijavu štete sa ID: {izabranaSteta.Id}?\nVrsta štete: {izabranaSteta.VrstaStete}",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (potvrda == DialogResult.Yes)
            {
                try
                {
                    using (ISession session = DataLayer.GetSession())
                    {
                        using (ITransaction tx = session.BeginTransaction())
                        {
                            session.Delete(izabranaSteta); 
                            tx.Commit();
                        }
                    }

                    MessageBox.Show("Prijava štete je uspešno obrisana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UcitajSteteIzBaze();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška pri brisanju štete: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}