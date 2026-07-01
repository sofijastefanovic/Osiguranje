using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;

namespace Osiguranje.Mapiranja
{
    internal class IstorijaIzmenaPolisaMap : ClassMap<IstorijaIzmenaPolisa>
    {
        public IstorijaIzmenaPolisaMap()
        {
            Table("ISTORIJA_IZMENA_POLISE"); 

            Id(x => x.Id, "id").GeneratedBy.Increment();  

            Map(x => x.TipIzmene, "tip_izmene");
            Map(x => x.DatumIzmene, "datum_izmene");
            Map(x => x.StaraVrednost, "stara_vrednost");
            Map(x => x.NovaVrednost, "nova_vrednost");

            References(x => x.Polisa, "broj_polise").Not.Nullable(); 
        }
    }
}
