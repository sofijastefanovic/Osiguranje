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
        public ZdravstvenoOsiguranjeMap()
        {
            Table("ZDRASTVENO_OSIGURANJE");  // Ovako se zove u bazi - ZDRASTVENO (bez 'v')
            KeyColumn("broj_polise");

            Map(x => x.MrezaUstanove, "mreza_ustanove");
            Map(x => x.GodisnjiLimit, "godisnji_limit");
        }
    }
}
