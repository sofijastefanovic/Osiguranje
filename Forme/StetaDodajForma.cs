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
        private int _idOstecenogLica = 0;
        private int _idPolise = 0;
        private int _idPredmeta = 0;

        private string _zapisnikPolicije = null;
        private string _servis = null;

        private decimal? _procenaOstecenja = null;

        private string _zdravstvenaDokumenta = null;
        private string _zdravstvenaUstanova = null;


        public Steta KreiranaSteta { get; private set; }

        public StetaDodajForma()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            UcitajKlijente();
            UcitajPolise();
            UcitajPredmete();
        }

        private void UcitajKlijente()
        {
            var klijenti = DTOManager.vratiSveKlijente();
            cmbOstecenoLice.DataSource = klijenti;
            cmbOstecenoLice.DisplayMember = "ImePrezimeNaziv";
            cmbOstecenoLice.ValueMember = "Id";
            cmbOstecenoLice.SelectedIndex = -1;
        }

        private void UcitajPolise()
        {
            var polise = DTOManager.vratiSvePolise();
            cmbPolisa.DataSource = polise;
            cmbPolisa.DisplayMember = "BrojPolise";
            cmbPolisa.ValueMember = "BrojPolise";
            cmbPolisa.SelectedIndex = -1;
        }

        private void UcitajPredmete()
        {
            var predmeti = DTOManager.vratiSvePredmete();
            cmbPredmetOsiguranja.DataSource = predmeti;
            cmbPredmetOsiguranja.DisplayMember = "TipPredmeta";
            cmbPredmetOsiguranja.ValueMember = "Id";
            cmbPredmetOsiguranja.SelectedIndex = -1;
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
                using (AutoStetaForma otvoriAuto = new AutoStetaForma())
                {
                    if (otvoriAuto.ShowDialog() == DialogResult.OK)
                    {
                        _zapisnikPolicije = otvoriAuto.KreiranaAutoSteta.ZapisnikPolicije;
                        _servis = otvoriAuto.KreiranaAutoSteta.Servis;
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) 
        {
            if (radioButton1.Checked)
            {
                using (ImovinskaStetaForma otvoriImovina = new ImovinskaStetaForma())
                {
                    if (otvoriImovina.ShowDialog() == DialogResult.OK)
                    {
                        _procenaOstecenja = otvoriImovina.KreiranaImovinskaSteta.ProcenaOstecenja;
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) 
        {
            if (radioButton2.Checked)
            {
                using (ZdravstvenaStetaForm otvoriZdravstvo = new ZdravstvenaStetaForm())
                {
                    if (otvoriZdravstvo.ShowDialog() == DialogResult.OK)
                    {
                        _zdravstvenaDokumenta = otvoriZdravstvo.KreiranaZdravstvenaSteta.ZdravstvenaDokumenta;
                        _zdravstvenaUstanova = otvoriZdravstvo.KreiranaZdravstvenaSteta.ZdravstvenaUstanova;
                    }
                }
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            // Validacija
            if (!rbAutoSteta.Checked && !radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Morate izabrati vrstu štete!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_idOstecenogLica == 0)
            {
                MessageBox.Show("Izaberite oštećeno lice!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_idPolise == 0)
            {
                MessageBox.Show("Izaberite polisu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_idPredmeta == 0)
            {
                MessageBox.Show("Izaberite predmet osiguranja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtIznos.Text, out decimal procenjeniIznos))
            {
                MessageBox.Show("Procenjeni iznos mora biti broj!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string vrstaStete = "";
            if (rbAutoSteta.Checked) vrstaStete = "Auto osiguranje";
            else if (radioButton1.Checked) vrstaStete = "Imovinsko osiguranje";
            else if (radioButton2.Checked) vrstaStete = "Zdravstveno osiguranje";

            try
            {
                Steta novaSteta = null;

                if (rbAutoSteta.Checked)
                {
                    if (string.IsNullOrEmpty(_zapisnikPolicije) || string.IsNullOrEmpty(_servis))
                    {
                        MessageBox.Show("Unesite podatke za auto štetu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    novaSteta = new AutoSteta
                    {
                        DatumPrijave = dateTimePicker1.Value,
                        DatumNastanka = dateTimePicker2.Value,
                        VrstaStete = vrstaStete,
                        OpisDogadjaja = txtOpis.Text,
                        Lokacija = txtLokacija.Text,
                        StatusPostupka = txtStatus.Text,
                        ProcenjeniIznos = procenjeniIznos,
                        ZapisnikPolicije = _zapisnikPolicije,
                        Servis = _servis,
                        OstecenoLice = new Klijent { Id = _idOstecenogLica },
                        Polisa = new Polisa { BrojPolise = _idPolise },
                        PredmetOsiguranja = new PredmetOsiguranja { Id = _idPredmeta }
                    };
                }
                else if (radioButton1.Checked)
                {
                    if (!_procenaOstecenja.HasValue)
                    {
                        MessageBox.Show("Unesite procenu oštećenja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    novaSteta = new ImovinskaSteta
                    {
                        DatumPrijave = dateTimePicker1.Value,
                        DatumNastanka = dateTimePicker2.Value,
                        VrstaStete = vrstaStete,
                        OpisDogadjaja = txtOpis.Text,
                        Lokacija = txtLokacija.Text,
                        StatusPostupka = txtStatus.Text,
                        ProcenjeniIznos = procenjeniIznos,
                        ProcenaOstecenja = _procenaOstecenja.Value,
                        OstecenoLice = new Klijent { Id = _idOstecenogLica },
                        Polisa = new Polisa { BrojPolise = _idPolise },
                        PredmetOsiguranja = new PredmetOsiguranja { Id = _idPredmeta }
                    };
                }
                else if (radioButton2.Checked)
                {
                    if (string.IsNullOrEmpty(_zdravstvenaDokumenta) || string.IsNullOrEmpty(_zdravstvenaUstanova))
                    {
                        MessageBox.Show("Unesite podatke za zdravstvenu štetu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    novaSteta = new ZdravstvenaSteta
                    {
                        DatumPrijave = dateTimePicker1.Value,
                        DatumNastanka = dateTimePicker2.Value,
                        VrstaStete = vrstaStete,
                        OpisDogadjaja = txtOpis.Text,
                        Lokacija = txtLokacija.Text,
                        StatusPostupka = txtStatus.Text,
                        ProcenjeniIznos = procenjeniIznos,
                        ZdravstvenaDokumenta = _zdravstvenaDokumenta,
                        ZdravstvenaUstanova = _zdravstvenaUstanova,
                        OstecenoLice = new Klijent { Id = _idOstecenogLica },
                        Polisa = new Polisa { BrojPolise = _idPolise },
                        PredmetOsiguranja = new PredmetOsiguranja { Id = _idPredmeta }
                    };
                }

                DTOManager.dodajStetu(novaSteta);
                MessageBox.Show("Šteta uspešno sačuvana!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čuvanju štete: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnObrisi_Click(object sender, EventArgs e)
        //{
            
        //}
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbPredmetOsiguranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPredmetOsiguranja.SelectedValue is int id)
                _idPredmeta = id;
        }

        private void cmbPolisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPolisa.SelectedValue is int id)
                _idPolise = id;
        }

        private void cmbOstecenoLice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOstecenoLice.SelectedValue is int id)
                _idOstecenogLica = id;
        }
    }
}