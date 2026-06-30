using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class PutovanjeMap : SubclassMap<Putovanje>
    {
        public PutovanjeMap()
        {
            Table("PUTOVANJE");
            KeyColumn("id_predmeta");

            Map(x => x.PeriodPutovanja, "period_putovanja");
        }
    }
}