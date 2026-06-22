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
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime);
            Map(x => x.Prezime);
            Map(x => x.Kontakt);
            Map(x => x.Status);
            Map(x => x.TipOsobe);

            Map(x => x.DatumAngazovanja, "DatumAngazovanja").Not.Nullable();
        }
    }
}
