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
            CompositeId(x => x.Id)
                .KeyReference(y => y.Steta, "ID_STETE") 
                .KeyReference(y => y.AngazovanaOsoba, "ID_ANGAZOVANE_OSOBE"); 

            Map(x => x.DatumProcene, "DATUM_PROCENE");
            Map(x => x.MetodProcene, "METOD_PROCENE");
            Map(x => x.Nalaz, "NALAZ");
            Map(x => x.Preporuka, "PREPORUKA");
            Map(x => x.ProcenjeniIznos, "PROCENJENI_IZNOS");
        }
    }
}
