using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class KlijentMap : ClassMap<Klijent>
    {
        public KlijentMap()
        {
            // 1. OBAVEZNO DOSLOVNO IME TABELE VELIKIM SLOVIMA (Rješava ORA-00942)
            Table("KLIJENT");

            // 2. Primarni ključ (Usklađen sa Oracle velikim slovima)
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            // 3. Mapiranje običnih kolona (Sve velikim slovima pod navodnicima)
            Map(x => x.ImePrezimeNaziv, "IME_PREZIME_NAZIV");
            Map(x => x.StatusKlijenata, "STATUS_KLIJENATA");
            Map(x => x.Ulica, "ULICA");
            Map(x => x.Broj, "BROJ");
            Map(x => x.DatumRegistracije, "DATUM_REGISTRACIJE").Not.Nullable();

            // 4. Mapiranje kolekcije Emailova (Ime pomoćne tabele i kolone VELIKIM SLOVIMA)
            HasMany(x => x.Emailovi)
                .Table("KLIJENT_EMAIL")
                .KeyColumn("ID_KLIJENTA") // Strani ključ u pomoćnoj tabeli koji pokazuje na Klijenta
                .Element("EMAIL")        // Naziv kolone u kojoj se zapravo nalazi string emaila
                .Cascade.All();

            // 5. Mapiranje kolekcije Telefona (Ime pomoćne tabele i kolone VELIKIM SLOVIMA)
            HasMany(x => x.Telefoni)
                .Table("KLIJENT_TELEFON")
                .KeyColumn("ID_KLIJENTA") // Strani ključ u pomoćnoj tabeli koji pokazuje na Klijenta
                .Element("TELEFON")       // Naziv kolone u kojoj se zapravo nalazi string telefona
                .Cascade.All();
        }
    }
}