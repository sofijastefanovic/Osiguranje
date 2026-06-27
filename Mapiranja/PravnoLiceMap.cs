using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    // PROMENJENO: Sa ClassMap prebačeno na SubclassMap jer nasleđuje Klijenta
    internal class PravnoLiceMap : SubclassMap<PravnoLice>
    {
        public PravnoLiceMap()
        {
            // 1. Naziv tabele u Oracle-u za pravna lica
            Table("PRAVNO_LICE");

            // 2. Ključ preko kojeg se spaja sa tabelom KLIJENT (Id iz bazne klase Klijent)
            // Koristimo isti ključ kao i kod ostalih podklasa (ID)
            KeyColumn("ID_KLIJENTA");

            // 3. Mapiranje specifičnih kolona za Pravno Lice
            Map(x => x.Pib, "PIB");
            Map(x => x.MaticniBroj, "MATICNI_BROJ");
            Map(x => x.Delatnost, "DELATNOST");
            Map(x => x.KontaktOsobe, "KONTAKT_OSOBE");
        }
    }
}