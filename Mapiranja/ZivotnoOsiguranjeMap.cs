using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class ZivotnoOsiguranjeMap : ClassMap<ZivotnoOsiguranje>
    {
        public ZivotnoOsiguranjeMap() {
            Map(x => x.TipIsplate);
            Map(x => x.SumaOsiguranja);
        }
    }
}
