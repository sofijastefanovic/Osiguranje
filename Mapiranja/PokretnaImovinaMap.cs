using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class PokretnaImovinaMap : SubclassMap<PokretnaImovina>
    {
        public PokretnaImovinaMap()
        {
            Table("POKRETNA_IMOVINA");
            KeyColumn("id_predmeta");

            Map(x => x.SerijskiBroj, "serijski_broj");
            Map(x => x.Naziv, "naziv");
            Map(x => x.Opis, "opis");
            Map(x => x.ProcenjenaVrednost, "procenjena_vrednost");
        }
    }
}
