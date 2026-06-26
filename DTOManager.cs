using NHibernate;
using NHibernate.Linq;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
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
                System.Windows.Forms.MessageBox.Show("Greška pri učitavanju klijenata: " + ec.Message);
            }

            return klijenti;
        }

        public static void dodajKlijenta(KlijentBasic k)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Klijent klijent = new Klijent();
                    klijent.ImePrezimeNaziv = k.ImePrezimeNaziv;
                    klijent.DatumRegistracije = k.DatumRegistracije;
                    klijent.StatusKlijenata = k.StatusKlijenata;
                    klijent.Ulica = k.Ulica;
                    klijent.Broj = k.Broj;
                    klijent.Emailovi = k.Emailovi;
                    klijent.Telefoni = k.Telefoni;

                    s.Save(klijent);
                    s.Flush();
                }
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show("Greška pri dodavanju klijenta: " + ec.Message);
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
                System.Windows.Forms.MessageBox.Show("Greška pri brisanju klijenta: " + ec.Message);
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
                        // POPRAVKA: Pošto konstruktor PolisaPregled traži stringove za Vlasnika i Agenta,
                        // izvlačimo tekstualne podatke iz povezanih objekata (proveravamo i da li nisu null)
                        string vlasnikPrikaz = p.VlasnikPolise != null ? p.VlasnikPolise.ImePrezimeNaziv : "";
                        string agentPrikaz = p.Agent != null ? p.Agent.Id.ToString() : ""; // Ili p.Agent.Ime/ImePrezime ako postoji to polje

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
                            vlasnikPrikaz,         // Prosleđen string umesto celog objekta Klijent
                            agentPrikaz            // Prosleđen string umesto celog objekta AngazovanaOsoba
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show("Greška pri učitavanju polisa: " + ec.Message);
            }

            return polise;
        }

        public static void dodajPolisu(PolisaBasic p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
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

                    // POPRAVKA: Preko ID-jeva iz PolisaBasic učitavamo cele entitete iz baze i vežemo ih za polisu
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
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show("Greška pri dodavanju polise: " + ec.Message);
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
                System.Windows.Forms.MessageBox.Show("Greška pri brisanju polise: " + ec.Message);
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
                System.Windows.Forms.MessageBox.Show("Greška pri učitavanju angažovanih osoba: " + ec.Message);
            }

            return osobe;
        }

        public static void dodajAngazovanu(AngazovanaOsobaBasic a)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
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
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show("Greška pri dodavanju angažovane osobe: " + ec.Message);
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
                System.Windows.Forms.MessageBox.Show("Greška pri brisanju angažovane osobe: " + ec.Message);
            }
        }

        #endregion
    }
}