using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    // PROMENJENO: Sa ClassMap prebačeno na SubclassMap jer nasleđuje klasu Polisa
    internal class ZivotnoOsiguranjeMap : SubclassMap<ZivotnoOsiguranje>
    {
        public ZivotnoOsiguranjeMap()
        {
            // 1. Naziv tabele u Oracle-u za životna osiguranja
            Table("ZIVOTNO_OSIGURANJE");

            // 2. Ključ preko kojeg se spaja sa krovnom tabelom POLISA
            // Proveri da li se ova kolona u tvojoj bazi zove tačno ID ili možda BROJ_POLISE
            KeyColumn("ID");

            // 3. Mapiranje specifičnih kolona za Životno Osiguranje
            Map(x => x.TipIsplate, "TIP_ISPLATE");
            Map(x => x.SumaOsiguranja, "SUMA_OSIGURANJA");
        }
    }
}