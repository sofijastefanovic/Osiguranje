using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje
{
    
    public class KlijentPregled
    {
        public int Id { get; set; }
        public string ImePrezimeNaziv { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string StatusKlijenata { get; set; }
        public string Ulica { get; set; }
        public string Broj { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public KlijentPregled() { }

        public KlijentPregled(int id, string imePrezimeNaziv, DateTime datumRegistracije,
                              string statusKlijenata, string ulica, string broj,
                              string email, string telefon)
        {
            Id = id;
            ImePrezimeNaziv = imePrezimeNaziv;
            DatumRegistracije = datumRegistracije;
            StatusKlijenata = statusKlijenata;
            Ulica = ulica;
            Broj = broj;
            Email = email;
            Telefon = telefon;
        }
    }

    public class KlijentBasic
    {
        public int Id { get; set; }
        public string ImePrezimeNaziv { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string StatusKlijenata { get; set; }
        public string Ulica { get; set; }
        public string Broj { get; set; }
        public IList<string> Emailovi { get; set; }
        public IList<string> Telefoni { get; set; }

        public KlijentBasic()
        {
            Emailovi = new List<string>();
            Telefoni = new List<string>();
        }
    }

    public class FizickoLicePregled : KlijentPregled
    {
        public string Jmbg { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Zanimanje { get; set; }

        public FizickoLicePregled() { }

        public FizickoLicePregled(int id, string imePrezimeNaziv, DateTime datumRegistracije,
                                  string statusKlijenata, string ulica, string broj,
                                  string email, string telefon,
                                  string jmbg, DateTime datumRodjenja, string zanimanje)
            : base(id, imePrezimeNaziv, datumRegistracije, statusKlijenata, ulica, broj, email, telefon)
        {
            Jmbg = jmbg;
            DatumRodjenja = datumRodjenja;
            Zanimanje = zanimanje;
        }
    }

    public class PravnoLicePregled : KlijentPregled
    {
        public string Pib { get; set; }
        public string MaticniBroj { get; set; }
        public string Delatnost { get; set; }
        public string KontaktOsobe { get; set; }

        public PravnoLicePregled() { }

        public PravnoLicePregled(int id, string imePrezimeNaziv, DateTime datumRegistracije,
                                 string statusKlijenata, string ulica, string broj,
                                 string email, string telefon,
                                 string pib, string maticniBroj, string delatnost, string kontaktOsobe)
            : base(id, imePrezimeNaziv, datumRegistracije, statusKlijenata, ulica, broj, email, telefon)
        {
            Pib = pib;
            MaticniBroj = maticniBroj;
            Delatnost = delatnost;
            KontaktOsobe = kontaktOsobe;
        }
    }

    public class JavnaInstitucijaPregled : KlijentPregled
    {
        public string Pib { get; set; }
        public string MaticniBroj { get; set; }
        public string Delatnost { get; set; }
        public string KontaktOsobe { get; set; }
        public string VrstaInstitucije { get; set; }

        public JavnaInstitucijaPregled() { }

        public JavnaInstitucijaPregled(int id, string imePrezimeNaziv, DateTime datumRegistracije,
                                       string statusKlijenata, string ulica, string broj,
                                       string email, string telefon,
                                       string pib, string maticniBroj, string delatnost,
                                       string kontaktOsobe, string vrstaInstitucije)
            : base(id, imePrezimeNaziv, datumRegistracije, statusKlijenata, ulica, broj, email, telefon)
        {
            Pib = pib;
            MaticniBroj = maticniBroj;
            Delatnost = delatnost;
            KontaktOsobe = kontaktOsobe;
            VrstaInstitucije = vrstaInstitucije;
        }
    }
}
