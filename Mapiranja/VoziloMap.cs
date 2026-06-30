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
        public VoziloMap()
        {
            Table("VOZILO");
            KeyColumn("id_predmeta");

            Map(x => x.Registracija, "registracija");
            Map(x => x.Marka, "marka");
            Map(x => x.Model, "model");
            Map(x => x.GodinaProizvodnje, "godina_proizvodnje");
            Map(x => x.ImeVlasnika, "ime_vlasnika");
            Map(x => x.PrezimeVlasnika, "prezime_vlasnika");

        }
    }
}
