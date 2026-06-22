using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class VoziloMap : SubclassMap<Vozilo>
    {
        public VoziloMap() {
            KeyColumn("Id");
            Map(x => x.Registracija);
            Map(x => x.Marka);
            Map(x => x.Model);
            Map(x => x.GodinaProizvodnje);
            Map(x => x.ImeVlasnika);
            Map(x => x.PrezimeVlasnika);

            References(x => x.AutoPolisa, "AutoPolisa");
        }
    }
}
