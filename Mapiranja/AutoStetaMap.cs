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
        public AutoStetaMap() {
            KeyColumn("Id");
            Map(x => x.ZapisnikPolicije);
            Map(x => x.Servis);
        }
    }
}
