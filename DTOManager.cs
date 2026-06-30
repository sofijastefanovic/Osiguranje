using NHibernate;
using NHibernate.Linq;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ISession = NHibernate.ISession;

namespace Osiguranje
{
    public class DTOManager
    {
        #region Klijent Metode

        public static List<KlijentPregled> vratiSveKlijente()
        {
            List<KlijentPregled> klijenti = new List<KlijentPregled>();

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var sviKlijenti = s.Query<Klijent>().ToList();

                    foreach (var k in sviKlijenti)
                    {
                        string email = k.Emailovi.Count > 0 ? k.Emailovi[0] : "";
                        string telefon = k.Telefoni.Count > 0 ? k.Telefoni[0] : "";

                        klijenti.Add(new KlijentPregled(
                            k.Id,
                            k.ImePrezimeNaziv,
                            k.DatumRegistracije,
                            k.StatusKlijenata,
                            k.Ulica,
                            k.Broj,
                            email,
                            telefon
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greška pri učitavanju klijenata: " + ec.Message);
            }

            return klijenti;
        }

        public static void dodajKlijenta(KlijentBasic k)
        {
            ISession s = null;
            ITransaction tx = null;

            try
            {
                s = DataLayer.GetSession();
                tx = s.BeginTransaction();

                if (k is FizickoLiceBasic fizicko)
                {
                    FizickoLice fl = new FizickoLice();
                    fl.ImePrezimeNaziv = fizicko.ImePrezimeNaziv;
                    fl.DatumRegistracije = fizicko.DatumRegistracije;
                    fl.StatusKlijenata = fizicko.StatusKlijenata;
                    fl.Ulica = fizicko.Ulica;
                    fl.Broj = fizicko.Broj;
                    fl.Emailovi = fizicko.Emailovi ?? new List<string>();
                    fl.Telefoni = fizicko.Telefoni ?? new List<string>();
                    fl.Jmbg = fizicko.Jmbg;
                    fl.DatumRodjenja = fizicko.DatumRodjenja;
                    fl.Zanimanje = fizicko.Zanimanje;

                    s.Save(fl);
                    s.Flush();
                }
                else if (k is PravnoLiceBasic pravno)
                {
                    PravnoLice pl = new PravnoLice();
                    pl.ImePrezimeNaziv = pravno.ImePrezimeNaziv;
                    pl.DatumRegistracije = pravno.DatumRegistracije;
                    pl.StatusKlijenata = pravno.StatusKlijenata;
                    pl.Ulica = pravno.Ulica;
                    pl.Broj = pravno.Broj;
                    pl.Emailovi = pravno.Emailovi ?? new List<string>();
                    pl.Telefoni = pravno.Telefoni ?? new List<string>();
                    pl.Pib = pravno.Pib;
                    pl.MaticniBroj = pravno.MaticniBroj;
                    pl.Delatnost = pravno.Delatnost;
                    pl.KontaktOsobe = pravno.KontaktOsobe;

                    s.Save(pl);
                    s.Flush();
                }
                else if (k is JavnaInstitucijaBasic javna)
                {
                    JavnaInstitucija ji = new JavnaInstitucija();
                    ji.ImePrezimeNaziv = javna.ImePrezimeNaziv;
                    ji.DatumRegistracije = javna.DatumRegistracije;
                    ji.StatusKlijenata = javna.StatusKlijenata;
                    ji.Ulica = javna.Ulica;
                    ji.Broj = javna.Broj;
                    ji.Emailovi = javna.Emailovi ?? new List<string>();
                    ji.Telefoni = javna.Telefoni ?? new List<string>();
                    ji.Pib = javna.Pib;
                    ji.MaticniBroj = javna.MaticniBroj;
                    ji.Delatnost = javna.Delatnost;
                    ji.KontaktOsobe = javna.KontaktOsobe;
                    ji.VrstaInstitucije = javna.VrstaInstitucije;

                    s.Save(ji);
                    s.Flush();
                }
                else
                {
                    Klijent klijent = new Klijent();
                    klijent.ImePrezimeNaziv = k.ImePrezimeNaziv;
                    klijent.DatumRegistracije = k.DatumRegistracije;
                    klijent.StatusKlijenata = k.StatusKlijenata;
                    klijent.Ulica = k.Ulica;
                    klijent.Broj = k.Broj;
                    klijent.Emailovi = k.Emailovi ?? new List<string>();
                    klijent.Telefoni = k.Telefoni ?? new List<string>();

                    s.Save(klijent);
                    s.Flush();
                }

                tx.Commit();
            }
            catch (Exception ec)
            {
                tx?.Rollback();
                MessageBox.Show("Greška pri dodavanju klijenta: " + ec.Message);
            }
            finally
            {
                s?.Close();
            }
        }

        public static void obrisiKlijenta(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Klijent klijent = s.Get<Klijent>(id);
                    if (klijent != null)
                    {
                        s.Delete(klijent);
                        s.Flush();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greška pri brisanju klijenta: " + ec.Message);
            }
        }

        #endregion

        #region AngazovanaOsoba Metode

        public static List<AngazovanaOsobaPregled> vratiSveAngazovane()
        {
            List<AngazovanaOsobaPregled> osobe = new List<AngazovanaOsobaPregled>();

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var sveOsobe = s.Query<AngazovanaOsoba>().ToList();

                    foreach (var o in sveOsobe)
                    {
                        osobe.Add(new AngazovanaOsobaPregled(
                            o.Id,
                            o.Ime,
                            o.Prezime,
                            o.Kontakt,
                            o.DatumAngazovanja,
                            o.Status,
                            o.TipOsobe
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greška pri učitavanju angažovanih osoba: " + ec.Message);
            }

            return osobe;
        }

        public static void dodajAngazovanu(AngazovanaOsobaBasic a)
        {
            ISession s = null;
            ITransaction tx = null;

            try
            {
                s = DataLayer.GetSession();
                tx = s.BeginTransaction();

                if (a is AgentBasic agent)
                {
                    Agent ag = new Agent();
                    ag.Ime = agent.Ime;
                    ag.Prezime = agent.Prezime;
                    ag.Kontakt = agent.Kontakt;
                    ag.DatumAngazovanja = agent.DatumAngazovanja;
                    ag.Status = agent.Status;
                    ag.TipOsobe = agent.TipOsobe;
                    ag.Licensa = agent.Licensa;
                    ag.Provizija = agent.Provizija;
                    ag.TipAgenta = agent.TipAgenta;

                    s.Save(ag);
                    s.Flush();
                }
                else if (a is ProceniteljBasic procenitelj)
                {
                    Procenitelj pr = new Procenitelj();
                    pr.Ime = procenitelj.Ime;
                    pr.Prezime = procenitelj.Prezime;
                    pr.Kontakt = procenitelj.Kontakt;
                    pr.DatumAngazovanja = procenitelj.DatumAngazovanja;
                    pr.Status = procenitelj.Status;
                    pr.TipOsobe = procenitelj.TipOsobe;
                    pr.Licensa = procenitelj.Licensa;
                    pr.TipProcenitelja = procenitelj.TipProcenitelja;

                    s.Save(pr);
                    s.Flush();
                }
                else if (a is PravnikBasic pravnik)
                {
                    Pravnik pr = new Pravnik();
                    pr.Ime = pravnik.Ime;
                    pr.Prezime = pravnik.Prezime;
                    pr.Kontakt = pravnik.Kontakt;
                    pr.DatumAngazovanja = pravnik.DatumAngazovanja;
                    pr.Status = pravnik.Status;
                    pr.TipOsobe = pravnik.TipOsobe;
                    pr.TipPravnika = pravnik.TipPravnika;

                    s.Save(pr);
                    s.Flush();
                }
                else if (a is LekarKonsultantBasic lekar)
                {
                    LekarKonsultant lk = new LekarKonsultant();
                    lk.Ime = lekar.Ime;
                    lk.Prezime = lekar.Prezime;
                    lk.Kontakt = lekar.Kontakt;
                    lk.DatumAngazovanja = lekar.DatumAngazovanja;
                    lk.Status = lekar.Status;
                    lk.TipOsobe = lekar.TipOsobe;

                    s.Save(lk);
                    s.Flush();
                }
                else
                {
                    AngazovanaOsoba osoba = new AngazovanaOsoba();
                    osoba.Ime = a.Ime;
                    osoba.Prezime = a.Prezime;
                    osoba.Kontakt = a.Kontakt;
                    osoba.DatumAngazovanja = a.DatumAngazovanja;
                    osoba.Status = a.Status;
                    osoba.TipOsobe = a.TipOsobe;

                    s.Save(osoba);
                    s.Flush();
                }

                tx.Commit();
            }
            catch (Exception ec)
            {
                tx?.Rollback();
                MessageBox.Show("Greška pri dodavanju angažovane osobe: " + ec.Message);
            }
            finally
            {
                s?.Close();
            }
        }

        public static void obrisiAngazovanu(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    AngazovanaOsoba osoba = s.Get<AngazovanaOsoba>(id);
                    if (osoba != null)
                    {
                        s.Delete(osoba);
                        s.Flush();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greška pri brisanju angažovane osobe: " + ec.Message);
            }
        }

        #endregion

        #region Polisa Metode

        public static List<PolisaPregled> vratiSvePolise()
        {
            List<PolisaPregled> polise = new List<PolisaPregled>();

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var svePolise = s.Query<Polisa>().ToList();

                    foreach (var p in svePolise)
                    {
                        string vlasnikPrikaz = p.VlasnikPolise != null ? p.VlasnikPolise.ImePrezimeNaziv : "";
                        string agentPrikaz = p.Agent != null ? p.Agent.Id.ToString() : "";

                        polise.Add(new PolisaPregled(
                            p.BrojPolise,
                            p.DatumZakljucenja,
                            p.PeriodVazenja,
                            p.TipOsiguranja,
                            p.Status,
                            p.OsnovnaPremija,
                            p.Valuta,
                            p.NacinPlacanja,
                            p.TipPolise,
                            vlasnikPrikaz,
                            agentPrikaz
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greška pri učitavanju polisa: " + ec.Message);
            }

            return polise;
        }

        public static void dodajPolisu(PolisaBasic p)
        {
            ISession s = null;
            ITransaction tx = null;

            try
            {
                s = DataLayer.GetSession();
                tx = s.BeginTransaction();

                if (p is AutoOsiguranjeBasic auto)
                {
                    AutoOsiguranje ao = new AutoOsiguranje();
                    ao.BrojPolise = auto.BrojPolise;
                    ao.DatumZakljucenja = auto.DatumZakljucenja;
                    ao.PeriodVazenja = auto.PeriodVazenja;
                    ao.TipOsiguranja = auto.TipOsiguranja;
                    ao.Status = auto.Status;
                    ao.OsnovnaPremija = auto.OsnovnaPremija;
                    ao.Valuta = auto.Valuta;
                    ao.NacinPlacanja = auto.NacinPlacanja;
                    ao.TipPolise = auto.TipPolise;
                    ao.BonusMalusKlasa = auto.BonusMalusKlasa;
                    ao.TeritorijalnoVazenje = auto.TeritorijalnoVazenje;

                    if (auto.IdVlasnikaPolise > 0)
                    {
                        ao.VlasnikPolise = s.Load<Klijent>(auto.IdVlasnikaPolise);
                    }
                    if (auto.IdAngazovaneOsobe > 0)
                    {
                        ao.Agent = s.Load<AngazovanaOsoba>(auto.IdAngazovaneOsobe);
                    }

                    s.Save(ao);
                    s.Flush();
                }
                else if (p is ZivotnoOsiguranjeBasic zivotno)
                {
                    ZivotnoOsiguranje zo = new ZivotnoOsiguranje();
                    zo.BrojPolise = zivotno.BrojPolise;
                    zo.DatumZakljucenja = zivotno.DatumZakljucenja;
                    zo.PeriodVazenja = zivotno.PeriodVazenja;
                    zo.TipOsiguranja = zivotno.TipOsiguranja;
                    zo.Status = zivotno.Status;
                    zo.OsnovnaPremija = zivotno.OsnovnaPremija;
                    zo.Valuta = zivotno.Valuta;
                    zo.NacinPlacanja = zivotno.NacinPlacanja;
                    zo.TipPolise = zivotno.TipPolise;
                    zo.TipIsplate = zivotno.TipIsplate;
                    zo.SumaOsiguranja = zivotno.SumaOsiguranja;

                    if (zivotno.IdVlasnikaPolise > 0)
                    {
                        zo.VlasnikPolise = s.Load<Klijent>(zivotno.IdVlasnikaPolise);
                    }
                    if (zivotno.IdAngazovaneOsobe > 0)
                    {
                        zo.Agent = s.Load<AngazovanaOsoba>(zivotno.IdAngazovaneOsobe);
                    }

                    s.Save(zo);
                    s.Flush();
                }
                else if (p is ZdravstvenoOsiguranjeBasic zdravstveno)
                {
                    ZdravstvenoOsiguranje zo = new ZdravstvenoOsiguranje();
                    zo.BrojPolise = zdravstveno.BrojPolise;
                    zo.DatumZakljucenja = zdravstveno.DatumZakljucenja;
                    zo.PeriodVazenja = zdravstveno.PeriodVazenja;
                    zo.TipOsiguranja = zdravstveno.TipOsiguranja;
                    zo.Status = zdravstveno.Status;
                    zo.OsnovnaPremija = zdravstveno.OsnovnaPremija;
                    zo.Valuta = zdravstveno.Valuta;
                    zo.NacinPlacanja = zdravstveno.NacinPlacanja;
                    zo.TipPolise = zdravstveno.TipPolise;
                    zo.MrezaUstanove = zdravstveno.MrezaUstanove;
                    zo.GodisnjiLimit = zdravstveno.GodisnjiLimit;

                    if (zdravstveno.IdVlasnikaPolise > 0)
                    {
                        zo.VlasnikPolise = s.Load<Klijent>(zdravstveno.IdVlasnikaPolise);
                    }
                    if (zdravstveno.IdAngazovaneOsobe > 0)
                    {
                        zo.Agent = s.Load<AngazovanaOsoba>(zdravstveno.IdAngazovaneOsobe);
                    }

                    s.Save(zo);
                    s.Flush();
                }
                else
                {
                    Polisa polisa = new Polisa();
                    polisa.BrojPolise = p.BrojPolise;
                    polisa.DatumZakljucenja = p.DatumZakljucenja;
                    polisa.PeriodVazenja = p.PeriodVazenja;
                    polisa.TipOsiguranja = p.TipOsiguranja;
                    polisa.Status = p.Status;
                    polisa.OsnovnaPremija = p.OsnovnaPremija;
                    polisa.Valuta = p.Valuta;
                    polisa.NacinPlacanja = p.NacinPlacanja;
                    polisa.TipPolise = p.TipPolise;

                    if (p.IdVlasnikaPolise > 0)
                    {
                        polisa.VlasnikPolise = s.Load<Klijent>(p.IdVlasnikaPolise);
                    }
                    if (p.IdAngazovaneOsobe > 0)
                    {
                        polisa.Agent = s.Load<AngazovanaOsoba>(p.IdAngazovaneOsobe);
                    }

                    s.Save(polisa);
                    s.Flush();
                }

                tx.Commit();
            }
            catch (Exception ec)
            {
                tx?.Rollback();
                MessageBox.Show("Greška pri dodavanju polise: " + ec.Message);
            }
            finally
            {
                s?.Close();
            }
        }

        public static void obrisiPolisu(int brojPolise)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Polisa polisa = s.Get<Polisa>(brojPolise);
                    if (polisa != null)
                    {
                        s.Delete(polisa);
                        s.Flush();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greška pri brisanju polise: " + ec.Message);
            }
        }

        #endregion

        #region PredmetOsiguranja Metode

        public static List<PredmetOsiguranjaPregled> vratiSvePredmete()
        {
            List<PredmetOsiguranjaPregled> predmeti = new List<PredmetOsiguranjaPregled>();

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var sviPredmeti = s.Query<PredmetOsiguranja>().ToList();

                    foreach (var p in sviPredmeti)
                    {
                        predmeti.Add(new PredmetOsiguranjaPregled(
                            p.Id,
                            p.TipPredmeta
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greška pri učitavanju predmeta: " + ec.Message);
            }

            return predmeti;
        }

        public static void dodajPredmet(PredmetOsiguranjaBasic p)
        {
            ISession s = null;
            ITransaction tx = null;

            try
            {
                s = DataLayer.GetSession();
                tx = s.BeginTransaction();

                if (p is VoziloBasic vozilo)
                {
                    Vozilo v = new Vozilo();
                    v.TipPredmeta = vozilo.TipPredmeta;
                    v.Registracija = vozilo.Registracija;
                    v.Marka = vozilo.Marka;
                    v.Model = vozilo.Model;
                    v.GodinaProizvodnje = vozilo.GodinaProizvodnje;
                    v.ImeVlasnika = vozilo.ImeVlasnika;
                    v.PrezimeVlasnika = vozilo.PrezimeVlasnika;
                    if (vozilo.BrojPoliseAuto > 0)
                    {
                        v.AutoPolisa = s.Load<Polisa>(vozilo.BrojPoliseAuto);
                    }

                    s.Save(v);
                    s.Flush();
                }
                else if (p is LiceBasic lice)
                {
                    Lice l = new Lice();
                    l.TipPredmeta = lice.TipPredmeta;
                    l.Jmbg = lice.Jmbg;
                    l.Ime = lice.Ime;
                    l.Prezime = lice.Prezime;
                    l.DatumRodjenja = lice.DatumRodjenja;

                    s.Save(l);
                    s.Flush();
                }
                else if (p is NekretninaBasic nekretnina)
                {
                    Nekretnina n = new Nekretnina();
                    n.TipPredmeta = nekretnina.TipPredmeta;
                    n.Adresa = nekretnina.Adresa;
                    n.TipObjekta = nekretnina.TipObjekta;
                    n.GodinaIzgradnje = nekretnina.GodinaIzgradnje;
                    n.Povrsina = nekretnina.Povrsina;
                    n.ProcenjenaVrednost = nekretnina.ProcenjenaVrednost;

                    s.Save(n);
                    s.Flush();
                }
                else if (p is PokretnaImovinaBasic pokretna)
                {
                    PokretnaImovina pi = new PokretnaImovina();
                    pi.TipPredmeta = pokretna.TipPredmeta;
                    pi.SerijskiBroj = pokretna.SerijskiBroj;
                    pi.Naziv = pokretna.Naziv;
                    pi.Opis = pokretna.Opis;
                    pi.ProcenjenaVrednost = pokretna.ProcenjenaVrednost;

                    s.Save(pi);
                    s.Flush();
                }
                else if (p is UsevBasic usev)
                {
                    Usev u = new Usev();
                    u.TipPredmeta = usev.TipPredmeta;
                    u.Vrsta = usev.Vrsta;
                    u.Lokacija = usev.Lokacija;
                    u.ProcenjenaVrednost = usev.ProcenjenaVrednost;

                    s.Save(u);
                    s.Flush();
                }
                else if (p is ZivotinjaBasic zivotinja)
                {
                    Zivotinja z = new Zivotinja();
                    z.TipPredmeta = zivotinja.TipPredmeta;
                    z.Vrsta = zivotinja.Vrsta;
                    z.Lokacija = zivotinja.Lokacija;
                    z.ProcenjenaVrednost = zivotinja.ProcenjenaVrednost;

                    s.Save(z);
                    s.Flush();
                }
                else if (p is OdgovornostBasic odgovornost)
                {
                    Odgovornost o = new Odgovornost();
                    o.TipPredmeta = odgovornost.TipPredmeta;
                    o.Opis = odgovornost.Opis;

                    s.Save(o);
                    s.Flush();
                }
                else if (p is PutovanjeBasic putovanje)
                {
                    Putovanje pu = new Putovanje();
                    pu.TipPredmeta = putovanje.TipPredmeta;
                    pu.PeriodPutovanja = putovanje.PeriodPutovanja;

                    s.Save(pu);
                    s.Flush();
                }
                else
                {
                    PredmetOsiguranja predmet = new PredmetOsiguranja();
                    predmet.TipPredmeta = p.TipPredmeta;

                    s.Save(predmet);
                    s.Flush();
                }

                tx.Commit();
            }
            catch (Exception ec)
            {
                tx?.Rollback();
                MessageBox.Show("Greška pri dodavanju predmeta: " + ec.Message);
            }
            finally
            {
                s?.Close();
            }
        }

        public static void obrisiPredmet(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    PredmetOsiguranja predmet = s.Get<PredmetOsiguranja>(id);
                    if (predmet != null)
                    {
                        s.Delete(predmet);
                        s.Flush();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greška pri brisanju predmeta: " + ec.Message);
            }
        }

        #endregion

        #region Steta Metode

        public static List<Steta> vratiSveStete()
        {
            List<Steta> stete = new List<Steta>();

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    stete = s.Query<Steta>().ToList();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greška pri učitavanju šteta: " + ec.Message);
            }

            return stete;
        }

        public static void dodajStetu(Steta steta)
        {
            ISession s = null;
            ITransaction tx = null;

            try
            {
                s = DataLayer.GetSession();
                tx = s.BeginTransaction();

                if (steta is AutoSteta autoSteta)
                {
                    AutoSteta as_ = new AutoSteta();
                    as_.DatumPrijave = autoSteta.DatumPrijave;
                    as_.DatumNastanka = autoSteta.DatumNastanka;
                    as_.VrstaStete = autoSteta.VrstaStete;
                    as_.OpisDogadjaja = autoSteta.OpisDogadjaja;
                    as_.Lokacija = autoSteta.Lokacija;
                    as_.StatusPostupka = autoSteta.StatusPostupka;
                    as_.ProcenjeniIznos = autoSteta.ProcenjeniIznos;
                    as_.ZapisnikPolicije = autoSteta.ZapisnikPolicije;
                    as_.Servis = autoSteta.Servis;

                    if (autoSteta.OstecenoLice != null && autoSteta.OstecenoLice.Id > 0)
                    {
                        as_.OstecenoLice = s.Load<Klijent>(autoSteta.OstecenoLice.Id);
                    }
                    if (autoSteta.Polisa != null && autoSteta.Polisa.BrojPolise > 0)
                    {
                        as_.Polisa = s.Load<Polisa>(autoSteta.Polisa.BrojPolise);
                    }
                    if (autoSteta.PredmetOsiguranja != null && autoSteta.PredmetOsiguranja.Id > 0)
                    {
                        as_.PredmetOsiguranja = s.Load<PredmetOsiguranja>(autoSteta.PredmetOsiguranja.Id);
                    }

                    s.Save(as_);
                    s.Flush();
                }
                else if (steta is ImovinskaSteta imovinskaSteta)
                {
                    ImovinskaSteta is_ = new ImovinskaSteta();
                    is_.DatumPrijave = imovinskaSteta.DatumPrijave;
                    is_.DatumNastanka = imovinskaSteta.DatumNastanka;
                    is_.VrstaStete = imovinskaSteta.VrstaStete;
                    is_.OpisDogadjaja = imovinskaSteta.OpisDogadjaja;
                    is_.Lokacija = imovinskaSteta.Lokacija;
                    is_.StatusPostupka = imovinskaSteta.StatusPostupka;
                    is_.ProcenjeniIznos = imovinskaSteta.ProcenjeniIznos;
                    is_.ProcenaOstecenja = imovinskaSteta.ProcenaOstecenja;

                    if (imovinskaSteta.OstecenoLice != null && imovinskaSteta.OstecenoLice.Id > 0)
                    {
                        is_.OstecenoLice = s.Load<Klijent>(imovinskaSteta.OstecenoLice.Id);
                    }
                    if (imovinskaSteta.Polisa != null && imovinskaSteta.Polisa.BrojPolise > 0)
                    {
                        is_.Polisa = s.Load<Polisa>(imovinskaSteta.Polisa.BrojPolise);
                    }
                    if (imovinskaSteta.PredmetOsiguranja != null && imovinskaSteta.PredmetOsiguranja.Id > 0)
                    {
                        is_.PredmetOsiguranja = s.Load<PredmetOsiguranja>(imovinskaSteta.PredmetOsiguranja.Id);
                    }

                    s.Save(is_);
                    s.Flush();
                }
                else if (steta is ZdravstvenaSteta zdravstvenaSteta)
                {
                    ZdravstvenaSteta zs = new ZdravstvenaSteta();
                    zs.DatumPrijave = zdravstvenaSteta.DatumPrijave;
                    zs.DatumNastanka = zdravstvenaSteta.DatumNastanka;
                    zs.VrstaStete = zdravstvenaSteta.VrstaStete;
                    zs.OpisDogadjaja = zdravstvenaSteta.OpisDogadjaja;
                    zs.Lokacija = zdravstvenaSteta.Lokacija;
                    zs.StatusPostupka = zdravstvenaSteta.StatusPostupka;
                    zs.ProcenjeniIznos = zdravstvenaSteta.ProcenjeniIznos;
                    zs.ZdravstvenaDokumenta = zdravstvenaSteta.ZdravstvenaDokumenta;
                    zs.ZdravstvenaUstanova = zdravstvenaSteta.ZdravstvenaUstanova;

                    if (zdravstvenaSteta.OstecenoLice != null && zdravstvenaSteta.OstecenoLice.Id > 0)
                    {
                        zs.OstecenoLice = s.Load<Klijent>(zdravstvenaSteta.OstecenoLice.Id);
                    }
                    if (zdravstvenaSteta.Polisa != null && zdravstvenaSteta.Polisa.BrojPolise > 0)
                    {
                        zs.Polisa = s.Load<Polisa>(zdravstvenaSteta.Polisa.BrojPolise);
                    }
                    if (zdravstvenaSteta.PredmetOsiguranja != null && zdravstvenaSteta.PredmetOsiguranja.Id > 0)
                    {
                        zs.PredmetOsiguranja = s.Load<PredmetOsiguranja>(zdravstvenaSteta.PredmetOsiguranja.Id);
                    }

                    s.Save(zs);
                    s.Flush();
                }
                else
                {
                    Steta novaSteta = new Steta();
                    novaSteta.DatumPrijave = steta.DatumPrijave;
                    novaSteta.DatumNastanka = steta.DatumNastanka;
                    novaSteta.VrstaStete = steta.VrstaStete;
                    novaSteta.OpisDogadjaja = steta.OpisDogadjaja;
                    novaSteta.Lokacija = steta.Lokacija;
                    novaSteta.StatusPostupka = steta.StatusPostupka;
                    novaSteta.ProcenjeniIznos = steta.ProcenjeniIznos;

                    if (steta.OstecenoLice != null && steta.OstecenoLice.Id > 0)
                    {
                        novaSteta.OstecenoLice = s.Load<Klijent>(steta.OstecenoLice.Id);
                    }
                    if (steta.Polisa != null && steta.Polisa.BrojPolise > 0)
                    {
                        novaSteta.Polisa = s.Load<Polisa>(steta.Polisa.BrojPolise);
                    }
                    if (steta.PredmetOsiguranja != null && steta.PredmetOsiguranja.Id > 0)
                    {
                        novaSteta.PredmetOsiguranja = s.Load<PredmetOsiguranja>(steta.PredmetOsiguranja.Id);
                    }

                    s.Save(novaSteta);
                    s.Flush();
                }

                tx.Commit();
            }
            catch (Exception ec)
            {
                tx?.Rollback();
                MessageBox.Show("Greška pri dodavanju štete: " + ec.Message);
            }
            finally
            {
                s?.Close();
            }
        }

        public static void obrisiStetu(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Steta steta = s.Get<Steta>(id);
                    if (steta != null)
                    {
                        s.Delete(steta);
                        s.Flush();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greška pri brisanju štete: " + ec.Message);
            }
        }

        #endregion

        #region FazaObradeStete Metode

        public static List<FazaObradeStete> vratiSveFaze()
        {
            List<FazaObradeStete> faze = new List<FazaObradeStete>();

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    faze = s.Query<FazaObradeStete>().ToList();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greška pri učitavanju faza: " + ec.Message);
            }

            return faze;
        }

        public static void dodajFazu(FazaObradeStete faza)
        {
            ISession s = null;
            ITransaction tx = null;

            try
            {
                s = DataLayer.GetSession();
                tx = s.BeginTransaction();

                FazaObradeStete novaFaza = new FazaObradeStete();
                novaFaza.DatumPocetka = faza.DatumPocetka;
                novaFaza.DatumZavrsetka = faza.DatumZavrsetka;
                novaFaza.OdgovornoLice = faza.OdgovornoLice;
                novaFaza.Odluka = faza.Odluka;
                novaFaza.PotrebnaDokumenta = faza.PotrebnaDokumenta;

                if (faza.Steta != null && faza.Steta.Id > 0)
                {
                    novaFaza.Steta = s.Load<Steta>(faza.Steta.Id);
                }

                s.Save(novaFaza);
                s.Flush();

                tx.Commit();
            }
            catch (Exception ec)
            {
                tx?.Rollback();
                MessageBox.Show("Greška pri dodavanju faze: " + ec.Message);
            }
            finally
            {
                s?.Close();
            }
        }

        public static void obrisiFazu(int redniBrojFaze)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    FazaObradeStete faza = s.Get<FazaObradeStete>(redniBrojFaze);
                    if (faza != null)
                    {
                        s.Delete(faza);
                        s.Flush();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greška pri brisanju faze: " + ec.Message);
            }
        }

        #endregion

        #region Procena Metode

        public static List<Procena> vratiSveProcene()
        {
            List<Procena> procene = new List<Procena>();

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    procene = s.Query<Procena>().ToList();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greška pri učitavanju procena: " + ec.Message);
            }

            return procene;
        }

        public static void dodajProceni(Procena procena)
        {
            ISession s = null;
            ITransaction tx = null;

            try
            {
                s = DataLayer.GetSession();
                tx = s.BeginTransaction();

                Procena novaProcena = new Procena();
                novaProcena.Id = new ProcenaId();
                novaProcena.Id.Steta = s.Load<Steta>(procena.Id.Steta.Id);
                novaProcena.Id.AngazovanaOsoba = s.Load<AngazovanaOsoba>(procena.Id.AngazovanaOsoba.Id);
                novaProcena.DatumProcene = procena.DatumProcene;
                novaProcena.MetodProcene = procena.MetodProcene;
                novaProcena.Nalaz = procena.Nalaz;
                novaProcena.Preporuka = procena.Preporuka;
                novaProcena.ProcenjeniIznos = procena.ProcenjeniIznos;

                s.Save(novaProcena);
                s.Flush();

                tx.Commit();
            }
            catch (Exception ec)
            {
                tx?.Rollback();
                MessageBox.Show("Greška pri dodavanju procene: " + ec.Message);
            }
            finally
            {
                s?.Close();
            }
        }

        public static void obrisiProceni(int stetaId, int angazovanaOsobaId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var procena = s.Query<Procena>()
                        .FirstOrDefault(p => p.Id.Steta.Id == stetaId && p.Id.AngazovanaOsoba.Id == angazovanaOsobaId);
                    if (procena != null)
                    {
                        s.Delete(procena);
                        s.Flush();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greška pri brisanju procene: " + ec.Message);
            }
        }

        #endregion
    }
}