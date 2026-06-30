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
            Table("KLIJENT");

            Id(x => x.Id, "id").GeneratedBy.SequenceIdentity();

            Map(x => x.ImePrezimeNaziv, "ime_prezime_naziv");
            Map(x => x.DatumRegistracije, "datum_registracije").Not.Nullable();
            Map(x => x.StatusKlijenata, "status_klijenata");
            Map(x => x.Ulica, "ulica");
            Map(x => x.Broj, "broj");

            // PROMENA: Tačna imena tabela
            HasMany(x => x.Emailovi)
                .Table("EMAIL_KLIJENT")
                .KeyColumn("id_klijent")
                .Element("email")
                .Cascade.All();

            HasMany(x => x.Telefoni)
                .Table("TELEFON_KLIJENT")
                .KeyColumn("id_klijent")
                .Element("telefon")
                .Cascade.All();
        }
    }
}