using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class ImovinskaStetaMap : SubclassMap<ImovinskaSteta>
    {
        public ImovinskaStetaMap() {
            KeyColumn("Id");
            Map(x => x.ProcenaOstecenja);
        }
    }
}
