using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class PravnikMap : SubclassMap<Pravnik>
    {
        public PravnikMap()
        {
            Table("PRAVNIK");
            KeyColumn("id_angazovane");

            Map(x => x.TipPravnika, "tip_pravnika");
        }
    }
}
