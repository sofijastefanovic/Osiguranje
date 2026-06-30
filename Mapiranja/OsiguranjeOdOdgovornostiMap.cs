using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class OsiguranjeOdOdgovornostiMap : SubclassMap<OsiguranjeOdOdgovornosti>
    {
        public OsiguranjeOdOdgovornostiMap()
        {
            Table("OSIGURANJE_OD_ODGOVORNOSTI");
            KeyColumn("broj_polise");
        }
    }
}
