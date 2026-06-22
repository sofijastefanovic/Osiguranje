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
        public PokretnaImovinaMap() {
            KeyColumn("Id");

            Map(x => x.SerijskiBroj);
            Map(x => x.Naziv);
            Map(x => x.Opis);
            Map(x => x.ProcenjenaVrednost);
        }
    }
}
