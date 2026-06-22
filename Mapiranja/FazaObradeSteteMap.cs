using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class FazaObradeSteteMap : ClassMap<FazaObradeStete>
    {
        public FazaObradeSteteMap()
        {
            Id(x => x.RedniBrojFaze, "RedniBrojFaze").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumPocetka, "DatumPocetka").Not.Nullable();
            Map(x => x.DatumZavrsetka, "DatumZavrsetka").Not.Nullable();

            Map(x => x.OdgovornoLice);
            Map(x => x.Odluka);
            Map(x => x.PotrebnaDokumenta);

            References(x => x.Steta, "Steta");
        }
    }
}
