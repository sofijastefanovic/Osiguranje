using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class UsevMap : SubclassMap<Usev>
    {
        public UsevMap()
        {
            Table("USEV");
            KeyColumn("id_predmeta");

            Map(x => x.Vrsta, "vrsta");
            Map(x => x.Lokacija, "lokacija");
            Map(x => x.ProcenjenaVrednost, "procenjena_vrednost");
        }
    }
}
