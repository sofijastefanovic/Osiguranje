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
        public UsevMap() {
            KeyColumn("Id");
            Map(x => x.Vrsta);
            Map(x => x.Lokacija);
            Map(x => x.ProcenjenaVrednost);
        }
    }
}
