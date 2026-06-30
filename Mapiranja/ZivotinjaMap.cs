using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class ZivotinjaMap : SubclassMap<Zivotinja>
    {
        public ZivotinjaMap()
        {
            Table("ZIVOTINJA");
            KeyColumn("id_predmeta");

            Map(x => x.Vrsta, "vrsta");
            Map(x => x.Lokacija, "lokacija");
            Map(x => x.ProcenjenaVrednost, "procenjena_vrednost");
        }
    }
}
