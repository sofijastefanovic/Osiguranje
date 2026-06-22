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
        public OsiguranjeOdOdgovornostiMap() {
            KeyColumn("BrojPolise");
        }
    }
}
