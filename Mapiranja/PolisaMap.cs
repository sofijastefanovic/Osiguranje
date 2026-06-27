using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;

namespace Osiguranje.Mapiranja
{
    internal class PolisaMap : ClassMap<Polisa>
    {
        public PolisaMap()
        {
            Id(x => x.BrojPolise, "BrojPolise").GeneratedBy.TriggerIdentity();

            Map(x => x.PeriodVazenja);
            Map(x => x.TipOsiguranja);
            Map(x => x.Status);
            Map(x => x.OsnovnaPremija);
            Map(x => x.Valuta);
            Map(x => x.NacinPlacanja);
            Map(x => x.TipPolise);

            Map(x => x.DatumZakljucenja, "DatumZakljucenja").Not.Nullable();

            References(x => x.VlasnikPolise, "VlasnikPolise");
            References(x => x.Agent, "Agent");
            //isto izmenaa
            HasMany(x => x.IstorijaIzmena).KeyColumn("Polisa_Id").Cascade.AllDeleteOrphan().Inverse();
            HasMany(x => x.DodatnaPokrica).KeyColumn("Polisa_Id").Cascade.AllDeleteOrphan().Inverse();
        }
    }
}
