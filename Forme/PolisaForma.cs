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
    public partial class PolisaForma : Form
    {
        public object ListView1 { get; private set; }

        public PolisaForma()
        {
            InitializeComponent();
            InicijalizujTabelu();
            UcitajPoliseUBazu();
        }

        private void InicijalizujTabelu()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("Broj Polise", 80);
            listView1.Columns.Add("Tip Osiguranika", 120);
            listView1.Columns.Add("Klijnet", 150);
            listView1.Columns.Add("Agent", 130);
            listView1.Columns.Add("Premija", 90);
            listView1.Columns.Add("Valuta", 60);
            listView1.Columns.Add("Status", 90);
            listView1.Columns.Add("Nacin Placanja", 110);
        }

        private void UcitajPoliseUBazu()
        {
            listView1.Items.Clear(); 

            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IList<Polisa> svePolise = session.QueryOver<Polisa>().List();

                    foreach (Polisa p in svePolise)
                    {
                        ListViewItem red = new ListViewItem(p.BrojPolise.ToString());

                        red.SubItems.Add(p.TipOsiguranja ?? "N/A");

                        string klijentInfo = p.VlasnikPolise != null ? $"Klijent ID: {p.VlasnikPolise.Id}" : "Nema klijenta";
                        red.SubItems.Add(klijentInfo);

                        string agentInfo = p.Agent != null ? $"{p.Agent.Ime} {p.Agent.Prezime}" : "Direktno";
                        red.SubItems.Add(agentInfo);

                        red.SubItems.Add(p.OsnovnaPremija.ToString("N2"));
                        red.SubItems.Add(p.Valuta ?? "RSD");
                        red.SubItems.Add(p.Status ?? "Aktivna");
                        red.SubItems.Add(p.NacinPlacanja ?? "Gotovina");

                        red.Tag = p;

                        listView1.Items.Add(red);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri komunikaciji sa bazom: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete polisu iz liste koju želite da izmenite.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selektovaniRed = listView1.SelectedItems[0];
            Polisa izabranaPolisa = (Polisa)selektovaniRed.Tag;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }
    }
}
