using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    // PROMENJENO: Sa ClassMap prebačeno na SubclassMap jer nasleđuje PredmetOsiguranja
    internal class PutovanjeMap : SubclassMap<Putovanje>
    {
        public PutovanjeMap()
        {
            // 1. Naziv tabele u Oracle-u za putovanja
            Table("PUTOVANJE");

            // 2. Ključ preko kojeg se spaja sa tabelom PREDMET_OSIGURANJA 
            // Proveri da li ti se u bazi ova kolona zove tačno ID ili ID_PREDMETA
            KeyColumn("ID");

            // 3. Mapiranje specifičnih kolona za Putovanje
            Map(x => x.PeriodPutovanja, "PERIOD_PUTOVANJA");
        }
    }
}