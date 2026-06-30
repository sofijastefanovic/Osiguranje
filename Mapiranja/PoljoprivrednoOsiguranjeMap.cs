using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class PoljoprivrednoOsiguranjeMap : SubclassMap<PoljoprivrednoOsiguranje>
    {
        public PoljoprivrednoOsiguranjeMap()
        {
            Table("POLJOPRIVREDNO_OSIGURANJE");
            KeyColumn("broj_polise");
        }
    }
}
