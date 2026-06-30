using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class FizickoLiceMap : SubclassMap<FizickoLice>
    {
        public FizickoLiceMap()
        {
            Table("FIZICKO_LICE");
            KeyColumn("id_klijent");

            Map(x => x.Jmbg, "jmbg");
            Map(x => x.DatumRodjenja, "datum_rodjenja").Not.Nullable();
            Map(x => x.Zanimanje, "zanimanje");
        }
    }
}