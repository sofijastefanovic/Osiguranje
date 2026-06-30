using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class JavnaInstitucijaMap : SubclassMap<JavnaInstitucija>
    {
        public JavnaInstitucijaMap()
        {
            Table("JAVNA_INSTITUCIJA");
            KeyColumn("id_klijent");  // PROMENA: id_klijent umesto ID_KLIJENTA

            Map(x => x.Pib, "pib");
            Map(x => x.MaticniBroj, "maticni_broj");
            Map(x => x.Delatnost, "delatnost");
            Map(x => x.KontaktOsobe, "kontakt_osobe");
            Map(x => x.VrstaInstitucije, "vrsta_institucije");
        }
    }
}