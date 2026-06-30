    using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class ZivotnoOsiguranjeMap : SubclassMap<ZivotnoOsiguranje>
    {
        public ZivotnoOsiguranjeMap()
        {
            Table("ZIVOTNO_OSIGURANJE");
            KeyColumn("broj_polise");

            Map(x => x.TipIsplate, "tip_isplate");
            Map(x => x.SumaOsiguranja, "suma_osiguranja");
        }
    }
}