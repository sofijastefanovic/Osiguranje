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
        public AutoOsiguranjeMap() {
            KeyColumn("Id");
            Map(x => x.BonusMalusKlasa);
            Map(x => x.TeritorijalnoVazenje);
        }
    }
}
