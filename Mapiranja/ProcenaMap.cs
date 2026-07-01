using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class ProcenaMap : ClassMap<Procena>
    {
        public ProcenaMap()
        {
            Table("PROCENA");  

            CompositeId(x => x.Id)
                .KeyReference(y => y.Steta, "steta_id")      
                .KeyReference(y => y.AngazovanaOsoba, "angazovana_osoba_id");  

            Map(x => x.DatumProcene, "datum_procene");
            Map(x => x.MetodProcene, "metod_procene");
            Map(x => x.Nalaz, "nalaz");
            Map(x => x.Preporuka, "preporuka");
            Map(x => x.ProcenjeniIznos, "procenjeni_iznos");
        }
    }
}