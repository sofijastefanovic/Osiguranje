using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class PravnoLiceMap : ClassMap<PravnoLice>
    {
        public PravnoLiceMap() {
            Map(x => x.Pib);
            Map(x => x.MaticniBroj);
            Map(x => x.Delatnost);
            Map(x => x.KontaktOsobe);
        }
    }
}
