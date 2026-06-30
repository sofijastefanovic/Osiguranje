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
        public AgentMap()
        {
            Table("AGENT");
            KeyColumn("id_angazovane");

            Map(x => x.Licensa, "licensa");
            Map(x => x.Provizija, "provizija");
            Map(x => x.TipAgenta, "tip_agenta");

        }
    }
}
