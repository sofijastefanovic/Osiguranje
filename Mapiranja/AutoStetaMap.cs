using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class AutoStetaMap : SubclassMap<AutoSteta>
    {
        public AutoStetaMap()
        {
            Table("AUTO_STETA");
            KeyColumn("id_stete");

            Map(x => x.ZapisnikPolicije, "zapisnik_policije");
            Map(x => x.Servis, "servis");
        }
    }
}
