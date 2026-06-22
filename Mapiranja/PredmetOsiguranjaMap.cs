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
        public PredmetOsiguranjaMap() {
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity();

            Map(x => x.TipPredmeta);
        }

        
    }
}
