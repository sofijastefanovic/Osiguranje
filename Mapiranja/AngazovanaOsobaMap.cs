using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class AngazovanaOsobaMap : ClassMap<AngazovanaOsoba>
    {
        public AngazovanaOsobaMap()
        {
            Table("ANGAZOVANA_OSOBA");

            Id(x => x.Id, "id").GeneratedBy.SequenceIdentity();

            Map(x => x.Ime, "ime");
            Map(x => x.Prezime, "prezime");
            Map(x => x.Kontakt, "kontakt");
            Map(x => x.DatumAngazovanja, "datum_angazovanja").Not.Nullable();
            Map(x => x.Status, "status");
            Map(x => x.TipOsobe, "tip_osobe");
        }
    }
}
