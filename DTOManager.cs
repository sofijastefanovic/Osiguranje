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
    }
}