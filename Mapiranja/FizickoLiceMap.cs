using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class FizickoLiceMap : ClassMap<FizickoLice>
    {
        public FizickoLiceMap() {
            Map(x => x.Jmbg);
            Map(x => x.DatumRodjenja, "DatumRodjenja").Not.Nullable();
            Map(x => x.Zanimanje);
        }

    }
}
