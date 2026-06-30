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
        public ZdravstvenaStetaMap()
        {
            Table("ZDRAVSTVENA_STETA");
            KeyColumn("id_stete");

            Map(x => x.ZdravstvenaDokumenta, "zdravstvena_dokumenta");
            Map(x => x.ZdravstvenaUstanova, "zdravstvena_ustanova");
        }
    }
}
