using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class LekarKonsultantMap : SubclassMap<LekarKonsultant>
    {
        public LekarKonsultantMap()
        {
            Table("LEKAR_KONSULTANT");
            KeyColumn("id_angazovane");
        }
    }
}
