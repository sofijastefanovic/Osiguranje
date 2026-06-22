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
        public ZivotinjaMap() {
            KeyColumn("Id");
            Map(x => x.Vrsta);
            Map(x => x.Lokacija);
            Map(x => x.ProcenjenaVrednost);
        }
    }
}
