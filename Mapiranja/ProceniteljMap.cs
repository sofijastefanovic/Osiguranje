using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class ProceniteljMap : SubclassMap<Procenitelj>
    {
        public ProceniteljMap()
        {
            Table("PROCENITELJ");
            KeyColumn("id_angazovane");

            Map(x => x.Licensa, "licensa");
            Map(x => x.TipProcenitelja, "tip_procenitelja");
        }
    }
}
