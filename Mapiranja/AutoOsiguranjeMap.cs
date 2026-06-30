using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class AutoOsiguranjeMap : SubclassMap<AutoOsiguranje>
    {
        public AutoOsiguranjeMap()
        {
            Table("AUTO_OSIGURANJE");
            KeyColumn("broj_polise");

            Map(x => x.BonusMalusKlasa, "bonus_malus_klasa");
            Map(x => x.TeritorijalnoVazenje, "teritorijalno_vazenje");

        }
    }
}
