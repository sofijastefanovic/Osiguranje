using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class LiceMap : SubclassMap<Lice>
    {
        public LiceMap() {
            KeyColumn("Id");

            Map(x => x.Jmbg);
            Map(x => x.Ime);
            Map(x => x.Prezime);

            Map(x => x.DatumRodjenja, "DatumRodjenja").Not.Nullable();
        }
    }
}
