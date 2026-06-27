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
    public partial class ProcenaForma : Form
    {
        public ProcenaForma()
        {
            InitializeComponent();
            InicijalizujTabelu();
            UcitajProceneIzBaze();
        }

        private void InicijalizujTabelu()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Scrollable = true;

            listView1.Columns.Add("Šteta ID", 70);
            listView1.Columns.Add("Osoba ID", 70);
            listView1.Columns.Add("Datum Procene", 100);
            listView1.Columns.Add("Metod Procene", 120);
            listView1.Columns.Add("Procenjeni Iznos", 110);
            listView1.Columns.Add("Nalaz", 150);
            listView1.Columns.Add("Preporuka", 150);
        }
        private void UcitajProceneIzBaze()
        {
            listView1.Items.Clear();

            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IList<Procena> sveProcene = session.QueryOver<Procena>().List();

                    foreach (Procena p in sveProcene)
                    {
                        string stetaIdStr = (p.Id != null && p.Id.Steta != null) ? p.Id.Steta.Id.ToString() : "N/A";
                        string osobaIdStr = (p.Id != null && p.Id.AngazovanaOsoba != null) ? p.Id.AngazovanaOsoba.Id.ToString() : "N/A";

                        ListViewItem red = new ListViewItem(stetaIdStr);

                        red.SubItems.Add(osobaIdStr);
                        red.SubItems.Add(p.DatumProcene.ToString("dd.MM.yyyy"));
                        red.SubItems.Add(p.MetodProcene ?? "N/A");
                        red.SubItems.Add(p.ProcenjeniIznos.ToString("N2") + " RSD");
                        red.SubItems.Add(p.Nalaz ?? "");
                        red.SubItems.Add(p.Preporuka ?? "");

                        red.Tag = p;

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
            using (ProcenaDodajForma otvoriDodaj = new ProcenaDodajForma())
            { otvoriDodaj.ShowDialog(); }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}