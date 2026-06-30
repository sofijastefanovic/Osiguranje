using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class PravnoLiceMap : SubclassMap<PravnoLice>
    {
        public PravnoLiceMap()
        {
            Table("PRAVNO_LICE");
            KeyColumn("id_klijent");

            Map(x => x.Pib, "pib");
            Map(x => x.MaticniBroj, "maticni_broj");
            Map(x => x.Delatnost, "delatnost");
            Map(x => x.KontaktOsobe, "kontakt_osobe");
        }
    }
}