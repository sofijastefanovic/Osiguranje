using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class OdgovornostMap : SubclassMap<Odgovornost>
    {
        public OdgovornostMap() {
            KeyColumn("Id");

            Map(x => x.Opis);

        }
    }
}
