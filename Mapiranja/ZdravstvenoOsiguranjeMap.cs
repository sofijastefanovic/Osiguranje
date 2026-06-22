using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class ZdravstvenoOsiguranjeMap : SubclassMap<ZdravstvenoOsiguranje>
    {
        public ZdravstvenoOsiguranjeMap() {
            KeyColumn("BrojPolise");
            Map(x => x.MrezaUstanove);
            Map(x => x.GodisnjiLimit);
        }
    }
}
