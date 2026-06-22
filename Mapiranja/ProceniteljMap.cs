using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class ProceniteljMap : SubclassMap<Procenitelj>
    {
        public ProceniteljMap() {
            KeyColumn("Id");
            Map(x => x.Licensa);
            Map(x => x.TipProcenitelja);
        }
    }
}
