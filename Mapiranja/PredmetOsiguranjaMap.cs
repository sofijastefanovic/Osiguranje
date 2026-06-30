using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class PredmetOsiguranjaMap : ClassMap<PredmetOsiguranja>
    {
        public PredmetOsiguranjaMap()
        {
            Table("PREDMET_OSIGURANJA");
            Id(x => x.Id, "id").GeneratedBy.Increment();  
            Map(x => x.TipPredmeta, "tip_predmeta");
        }
    }
}
