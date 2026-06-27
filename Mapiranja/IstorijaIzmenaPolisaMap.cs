using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;

namespace Osiguranje.Mapiranja
{
    internal class IstorijaIzmenaPolisaMap : ClassMap<IstorijaIzmenaPolisa>
    {
        public IstorijaIzmenaPolisaMap()
        {
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity();

            Map(x => x.TipIzmene, "Tip_izmene");
            Map(x => x.DatumIzmene, "Datum_izmene");
            Map(x => x.StaraVrednost, "Stara_vrednost");
            Map(x => x.NovaVrednost, "Nova_vrednost");

            References(x => x.Polisa, "Polisa_Id").Not.Nullable();
        }
    }
}
