using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate; 

namespace Osiguranje.Forme
{
    public partial class FazaObradeSteteForma : Form
    {
        public FazaObradeSteteForma()
        {
            InitializeComponent();
            InicijalizujTabelu();
            UcitajFazeIzBaze();
        }

        private void InicijalizujTabelu()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Scrollable = true;

            listView1.Columns.Add("RB Faze", 70);
            listView1.Columns.Add("Datum Početka", 100);
            listView1.Columns.Add("Datum Završetka", 100);
            listView1.Columns.Add("Odgovorno Lice", 130);
            listView1.Columns.Add("Odluka", 120);
            listView1.Columns.Add("Potrebna Dokumenta", 150);
            listView1.Columns.Add("Šteta ID", 80);
        }

        private void UcitajFazeIzBaze()
        {
            listView1.Items.Clear();

            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IList<FazaObradeStete> sveFaze = session.QueryOver<FazaObradeStete>().List();

                    foreach (FazaObradeStete f in sveFaze)
                    {
                        ListViewItem red = new ListViewItem(f.RedniBrojFaze.ToString());

                        red.SubItems.Add(f.DatumPocetka.ToString("dd.MM.yyyy"));

                        red.SubItems.Add(f.DatumZavrsetka != DateTime.MinValue ? f.DatumZavrsetka.ToString("dd.MM.yyyy") : "U toku");

                        red.SubItems.Add(f.OdgovornoLice ?? "Nije dodeljeno");
                        red.SubItems.Add(f.Odluka ?? "Nema odluke");
                        red.SubItems.Add(f.PotrebnaDokumenta ?? "Nema");

                        string stetaInfo = f.Steta != null ? f.Steta.Id.ToString() : "N/A";
                        red.SubItems.Add(stetaInfo);

                        red.Tag = f;

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

        private void button1_Click(object sender, EventArgs e)
        {
            using (FazaObradeSteteDodajForma otvoriDodaj = new FazaObradeSteteDodajForma())
            {
                if (otvoriDodaj.ShowDialog() == DialogResult.OK)
                {
                    UcitajFazeIzBaze();
                }
            }
        }

        private void btnObrisiFazu_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete fazu obrade koju želite da obrišete.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selektovaniRed = listView1.SelectedItems[0];
            FazaObradeStete izabranaFaza = (FazaObradeStete)selektovaniRed.Tag;

            DialogResult potvrda = MessageBox.Show(
                $"Da li ste sigurni da želite da obrišete fazu broj: {izabranaFaza.RedniBrojFaze}?",
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
                            session.Delete(izabranaFaza);
                            tx.Commit();
                        }
                    }

                    MessageBox.Show("Faza obrade je uspešno obrisana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UcitajFazeIzBaze();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška pri brisanju faze: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}