using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class LekarSteteMap : ClassMap<LekarStete>
    {
        public LekarSteteMap() {
            CompositeId(x => x.Id)
                .KeyReference(y => y.Steta, "IdSteta")
                .KeyReference(y => y.Lekar, "IdLekar");
        }
    }
}
