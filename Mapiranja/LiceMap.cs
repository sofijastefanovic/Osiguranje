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
        public LiceMap()
        {
            Table("LICE");
            KeyColumn("id_predmeta");

            Map(x => x.Jmbg, "jmbg");
            Map(x => x.Ime, "ime");
            Map(x => x.Prezime, "prezime");
            Map(x => x.DatumRodjenja, "datum_rodjenja").Not.Nullable();
        }
    }
}
