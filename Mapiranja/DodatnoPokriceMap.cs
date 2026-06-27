using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;

namespace Osiguranje.Mapiranja
{
    internal class DodatnoPokriceMap : ClassMap<DodatnoPokrice>
    {
        public DodatnoPokriceMap()
        {
            CompositeId()
                .KeyReference(x => x.Polisa, "Polisa_Id")
                .KeyProperty(x => x.RedniBroj, "Redni_broj");

            Map(x => x.Naziv, "Naziv");
            Map(x => x.Opis, "Opis");
            Map(x => x.Limit, "Limit");
            Map(x => x.Fransiza, "Fransiza");
            Map(x => x.DodatnaPremija, "Dodatna_premija");
        }
    }
}
