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
        public ImovinskaStetaMap()
        {
            Table("IMOVINSKA_STETA");
            KeyColumn("id_stete");

            Map(x => x.ProcenaOstecenja, "procena_ostecenja");
        }
    }
}
