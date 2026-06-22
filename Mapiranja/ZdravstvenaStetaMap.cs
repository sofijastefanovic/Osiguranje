using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class ZdravstvenaStetaMap : SubclassMap<ZdravstvenaSteta>
    {
        public ZdravstvenaStetaMap() {
            KeyColumn("Id");
            Map(x => x.ZdravstvenaDokumenta);
            Map(x => x.ZdravstvenaUstanova);
        }
    }
}
