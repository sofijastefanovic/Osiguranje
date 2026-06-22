using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class AgentMap : SubclassMap<Agent>
    {
        public AgentMap() {
            KeyColumn("Id");
            Map(x => x.Licensa);
            Map(x => x.Provizija);
            Map(x => x.TipAgenta);
        }
    }
}
