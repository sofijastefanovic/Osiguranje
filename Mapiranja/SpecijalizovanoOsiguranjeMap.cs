using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class SpecijalizovanoOsiguranjeMap : SubclassMap<SpecijalizovanoOsiguranje>
    {
        public SpecijalizovanoOsiguranjeMap()
        {
            Table("SPECIJALIZOVANO_OSIGURANJE");
            KeyColumn("broj_polise");
        }
    }
}
