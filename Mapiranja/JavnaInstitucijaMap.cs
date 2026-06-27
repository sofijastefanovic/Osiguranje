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
    internal class JavnaInstitucijaMap : SubclassMap<JavnaInstitucija>
    {
        public JavnaInstitucijaMap()
        {
            // 1. Naziv tabele u Oracle-u
            Table("JAVNA_INSTITUCIJA");

            // 2. Ključ preko kojeg se povezuje sa tabelom KLIJENT (Id iz bazne klase Klijent)
            // Napomena: Proveri da li se kolona u bazi zove tačno ID ili ID_KLIJENTA
            KeyColumn("ID_KLIJENTA");

            // 3. Mapiranje specifičnih kolona za Javnu Instituciju
            Map(x => x.Pib, "PIB");
            Map(x => x.MaticniBroj, "MATICNI_BROJ");
            Map(x => x.Delatnost, "DELATNOST");
            Map(x => x.KontaktOsobe, "KONTAKT_OSOBE");
            Map(x => x.VrstaInstitucije, "VRSTA_INSTITUCIJE");
        }
    }
}