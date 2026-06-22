using System;
using System.Collections.Generic;

namespace Osiguranje
{
    // ==================== KLIJENT ====================

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

    // ==================== FIZICKO LICE ====================

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

    public class FizickoLiceBasic : KlijentBasic
    {
        public string Jmbg { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Zanimanje { get; set; }
    }

    // ==================== PRAVNO LICE ====================

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

    public class PravnoLiceBasic : KlijentBasic
    {
        public string Pib { get; set; }
        public string MaticniBroj { get; set; }
        public string Delatnost { get; set; }
        public string KontaktOsobe { get; set; }
    }

    // ==================== JAVNA INSTITUCIJA ====================

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

    public class JavnaInstitucijaBasic : KlijentBasic
    {
        public string Pib { get; set; }
        public string MaticniBroj { get; set; }
        public string Delatnost { get; set; }
        public string KontaktOsobe { get; set; }
        public string VrstaInstitucije { get; set; }
    }

    // ==================== ANGAZOVANA OSOBA ====================

    public class AngazovanaOsobaPregled
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Kontakt { get; set; }
        public DateTime DatumAngazovanja { get; set; }
        public string Status { get; set; }
        public string TipOsobe { get; set; }

        public AngazovanaOsobaPregled() { }

        public AngazovanaOsobaPregled(int id, string ime, string prezime, string kontakt,
                                      DateTime datumAngazovanja, string status, string tipOsobe)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            Kontakt = kontakt;
            DatumAngazovanja = datumAngazovanja;
            Status = status;
            TipOsobe = tipOsobe;
        }
    }

    public class AngazovanaOsobaBasic
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Kontakt { get; set; }
        public DateTime DatumAngazovanja { get; set; }
        public string Status { get; set; }
        public string TipOsobe { get; set; }
    }

    // ==================== AGENT ====================

    public class AgentPregled : AngazovanaOsobaPregled
    {
        public string Licensa { get; set; }
        public decimal Provizija { get; set; }
        public string TipAgenta { get; set; }

        public AgentPregled() { }

        public AgentPregled(int id, string ime, string prezime, string kontakt,
                            DateTime datumAngazovanja, string status, string tipOsobe,
                            string licensa, decimal provizija, string tipAgenta)
            : base(id, ime, prezime, kontakt, datumAngazovanja, status, tipOsobe)
        {
            Licensa = licensa;
            Provizija = provizija;
            TipAgenta = tipAgenta;
        }
    }

    public class AgentBasic : AngazovanaOsobaBasic
    {
        public string Licensa { get; set; }
        public decimal Provizija { get; set; }
        public string TipAgenta { get; set; }
    }

    // ==================== PROCENITELJ ====================

    public class ProceniteljPregled : AngazovanaOsobaPregled
    {
        public string Licensa { get; set; }
        public string TipProcenitelja { get; set; }

        public ProceniteljPregled() { }

        public ProceniteljPregled(int id, string ime, string prezime, string kontakt,
                                  DateTime datumAngazovanja, string status, string tipOsobe,
                                  string licensa, string tipProcenitelja)
            : base(id, ime, prezime, kontakt, datumAngazovanja, status, tipOsobe)
        {
            Licensa = licensa;
            TipProcenitelja = tipProcenitelja;
        }
    }

    public class ProceniteljBasic : AngazovanaOsobaBasic
    {
        public string Licensa { get; set; }
        public string TipProcenitelja { get; set; }
    }

    // ==================== LEKAR KONSULTANT ====================

    public class LekarKonsultantPregled : AngazovanaOsobaPregled
    {
        public LekarKonsultantPregled() { }

        public LekarKonsultantPregled(int id, string ime, string prezime, string kontakt,
                                      DateTime datumAngazovanja, string status, string tipOsobe)
            : base(id, ime, prezime, kontakt, datumAngazovanja, status, tipOsobe) { }
    }

    public class LekarKonsultantBasic : AngazovanaOsobaBasic { }

    // ==================== PRAVNIK ====================

    public class PravnikPregled : AngazovanaOsobaPregled
    {
        public string TipPravnika { get; set; }

        public PravnikPregled() { }

        public PravnikPregled(int id, string ime, string prezime, string kontakt,
                              DateTime datumAngazovanja, string status, string tipOsobe,
                              string tipPravnika)
            : base(id, ime, prezime, kontakt, datumAngazovanja, status, tipOsobe)
        {
            TipPravnika = tipPravnika;
        }
    }

    public class PravnikBasic : AngazovanaOsobaBasic
    {
        public string TipPravnika { get; set; }
    }

    // ==================== POLISA ====================

    public class PolisaPregled
    {
        public int BrojPolise { get; set; }
        public DateTime DatumZakljucenja { get; set; }
        public int PeriodVazenja { get; set; }
        public string TipOsiguranja { get; set; }
        public string Status { get; set; }
        public decimal OsnovnaPremija { get; set; }
        public string Valuta { get; set; }
        public string NacinPlacanja { get; set; }
        public string TipPolise { get; set; }
        public string VlasnikPolise { get; set; }
        public string Agent { get; set; }

        public PolisaPregled() { }

        public PolisaPregled(int brojPolise, DateTime datumZakljucenja, int periodVazenja,
                             string tipOsiguranja, string status, decimal osnovnaPremija,
                             string valuta, string nacinPlacanja, string tipPolise,
                             string vlasnikPolise, string agent)
        {
            BrojPolise = brojPolise;
            DatumZakljucenja = datumZakljucenja;
            PeriodVazenja = periodVazenja;
            TipOsiguranja = tipOsiguranja;
            Status = status;
            OsnovnaPremija = osnovnaPremija;
            Valuta = valuta;
            NacinPlacanja = nacinPlacanja;
            TipPolise = tipPolise;
            VlasnikPolise = vlasnikPolise;
            Agent = agent;
        }
    }

    public class PolisaBasic
    {
        public int BrojPolise { get; set; }
        public DateTime DatumZakljucenja { get; set; }
        public int PeriodVazenja { get; set; }
        public string TipOsiguranja { get; set; }
        public string Status { get; set; }
        public decimal OsnovnaPremija { get; set; }
        public string Valuta { get; set; }
        public string NacinPlacanja { get; set; }
        public string TipPolise { get; set; }
        public int IdVlasnikaPolise { get; set; }
        public int IdAngazovaneOsobe { get; set; }
    }

    // ==================== AUTO OSIGURANJE ====================

    public class AutoOsiguranjePregled : PolisaPregled
    {
        public int BonusMalusKlasa { get; set; }
        public string TeritorijalnoVazenje { get; set; }

        public AutoOsiguranjePregled() { }

        public AutoOsiguranjePregled(int brojPolise, DateTime datumZakljucenja, int periodVazenja,
                                     string tipOsiguranja, string status, decimal osnovnaPremija,
                                     string valuta, string nacinPlacanja, string tipPolise,
                                     string vlasnikPolise, string agent,
                                     int bonusMalusKlasa, string teritorijalnoVazenje)
            : base(brojPolise, datumZakljucenja, periodVazenja, tipOsiguranja, status,
                   osnovnaPremija, valuta, nacinPlacanja, tipPolise, vlasnikPolise, agent)
        {
            BonusMalusKlasa = bonusMalusKlasa;
            TeritorijalnoVazenje = teritorijalnoVazenje;
        }
    }

    public class AutoOsiguranjeBasic : PolisaBasic
    {
        public int BonusMalusKlasa { get; set; }
        public string TeritorijalnoVazenje { get; set; }
    }

    // ==================== ZIVOTNO OSIGURANJE ====================

    public class ZivotnoOsiguranjePregled : PolisaPregled
    {
        public string TipIsplate { get; set; }
        public decimal SumaOsiguranja { get; set; }

        public ZivotnoOsiguranjePregled() { }

        public ZivotnoOsiguranjePregled(int brojPolise, DateTime datumZakljucenja, int periodVazenja,
                                        string tipOsiguranja, string status, decimal osnovnaPremija,
                                        string valuta, string nacinPlacanja, string tipPolise,
                                        string vlasnikPolise, string agent,
                                        string tipIsplate, decimal sumaOsiguranja)
            : base(brojPolise, datumZakljucenja, periodVazenja, tipOsiguranja, status,
                   osnovnaPremija, valuta, nacinPlacanja, tipPolise, vlasnikPolise, agent)
        {
            TipIsplate = tipIsplate;
            SumaOsiguranja = sumaOsiguranja;
        }
    }

    public class ZivotnoOsiguranjeBasic : PolisaBasic
    {
        public string TipIsplate { get; set; }
        public decimal SumaOsiguranja { get; set; }
    }

    // ==================== ZDRAVSTVENO OSIGURANJE ====================

    public class ZdravstvenoOsiguranjePregled : PolisaPregled
    {
        public string MrezaUstanove { get; set; }
        public decimal GodisnjiLimit { get; set; }

        public ZdravstvenoOsiguranjePregled() { }

        public ZdravstvenoOsiguranjePregled(int brojPolise, DateTime datumZakljucenja, int periodVazenja,
                                            string tipOsiguranja, string status, decimal osnovnaPremija,
                                            string valuta, string nacinPlacanja, string tipPolise,
                                            string vlasnikPolise, string agent,
                                            string mrezaUstanove, decimal godisnjiLimit)
            : base(brojPolise, datumZakljucenja, periodVazenja, tipOsiguranja, status,
                   osnovnaPremija, valuta, nacinPlacanja, tipPolise, vlasnikPolise, agent)
        {
            MrezaUstanove = mrezaUstanove;
            GodisnjiLimit = godisnjiLimit;
        }
    }

    public class ZdravstvenoOsiguranjeBasic : PolisaBasic
    {
        public string MrezaUstanove { get; set; }
        public decimal GodisnjiLimit { get; set; }
    }

    // ==================== PREDMET OSIGURANJA ====================

    public class PredmetOsiguranjaPregled
    {
        public int Id { get; set; }
        public string TipPredmeta { get; set; }

        public PredmetOsiguranjaPregled() { }

        public PredmetOsiguranjaPregled(int id, string tipPredmeta)
        {
            Id = id;
            TipPredmeta = tipPredmeta;
        }
    }

    public class PredmetOsiguranjaBasic
    {
        public int Id { get; set; }
        public string TipPredmeta { get; set; }
    }

    // ==================== VOZILO ====================

    public class VoziloPregled : PredmetOsiguranjaPregled
    {
        public string Registracija { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int GodinaProizvodnje { get; set; }
        public string ImeVlasnika { get; set; }
        public string PrezimeVlasnika { get; set; }
        public string AutoPolisa { get; set; }

        public VoziloPregled() { }

        public VoziloPregled(int id, string tipPredmeta, string registracija, string marka,
                            string model, int godinaProizvodnje, string imeVlasnika,
                            string prezimeVlasnika, string autoPolisa)
            : base(id, tipPredmeta)
        {
            Registracija = registracija;
            Marka = marka;
            Model = model;
            GodinaProizvodnje = godinaProizvodnje;
            ImeVlasnika = imeVlasnika;
            PrezimeVlasnika = prezimeVlasnika;
            AutoPolisa = autoPolisa;
        }
    }

    public class VoziloBasic : PredmetOsiguranjaBasic
    {
        public string Registracija { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int GodinaProizvodnje { get; set; }
        public string ImeVlasnika { get; set; }
        public string PrezimeVlasnika { get; set; }
        public int BrojPoliseAuto { get; set; }
    }

    // ==================== NEKRETNINA ====================

    public class NekretninaPregled : PredmetOsiguranjaPregled
    {
        public string Adresa { get; set; }
        public string TipObjekta { get; set; }
        public int GodinaIzgradnje { get; set; }
        public decimal Povrsina { get; set; }
        public decimal ProcenjenaVrednost { get; set; }

        public NekretninaPregled() { }

        public NekretninaPregled(int id, string tipPredmeta, string adresa, string tipObjekta,
                                int godinaIzgradnje, decimal povrsina, decimal procenjenaVrednost)
            : base(id, tipPredmeta)
        {
            Adresa = adresa;
            TipObjekta = tipObjekta;
            GodinaIzgradnje = godinaIzgradnje;
            Povrsina = povrsina;
            ProcenjenaVrednost = procenjenaVrednost;
        }
    }

    public class NekretninaBasic : PredmetOsiguranjaBasic
    {
        public string Adresa { get; set; }
        public string TipObjekta { get; set; }
        public int GodinaIzgradnje { get; set; }
        public decimal Povrsina { get; set; }
        public decimal ProcenjenaVrednost { get; set; }
    }

    // ==================== STETA ====================

    public class StetaPregled
    {
        public int Id { get; set; }
        public DateTime DatumPrijave { get; set; }
        public DateTime DatumNastanka { get; set; }
        public string VrstaStete { get; set; }
        public string OpisDogadjaja { get; set; }
        public string Lokacija { get; set; }
        public string StatusPostupka { get; set; }
        public decimal ProcenjeniIznos { get; set; }
        public string OstecenoLice { get; set; }
        public string Polisa { get; set; }
        public string PredmetOsiguranja { get; set; }

        public StetaPregled() { }

        public StetaPregled(int id, DateTime datumPrijave, DateTime datumNastanka,
                           string vrstaStete, string opisDogadjaja, string lokacija,
                           string statusPostupka, decimal procenjeniIznos,
                           string ostecenoLice, string polisa, string predmetOsiguranja)
        {
            Id = id;
            DatumPrijave = datumPrijave;
            DatumNastanka = datumNastanka;
            VrstaStete = vrstaStete;
            OpisDogadjaja = opisDogadjaja;
            Lokacija = lokacija;
            StatusPostupka = statusPostupka;
            ProcenjeniIznos = procenjeniIznos;
            OstecenoLice = ostecenoLice;
            Polisa = polisa;
            PredmetOsiguranja = predmetOsiguranja;
        }
    }

    public class StetaBasic
    {
        public int Id { get; set; }
        public DateTime DatumPrijave { get; set; }
        public DateTime DatumNastanka { get; set; }
        public string VrstaStete { get; set; }
        public string OpisDogadjaja { get; set; }
        public string Lokacija { get; set; }
        public string StatusPostupka { get; set; }
        public decimal ProcenjeniIznos { get; set; }
        public int IdOstecenogLica { get; set; }
        public int IdPolise { get; set; }
        public int IdPredmetaOsiguranja { get; set; }
    }
}