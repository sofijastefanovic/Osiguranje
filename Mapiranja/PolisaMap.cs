using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;

namespace Osiguranje.Mapiranja
{
    internal class PolisaMap : ClassMap<Polisa>
    {
        public PolisaMap()
        {
            Table("POLISA");

            Id(x => x.BrojPolise, "broj_polise").GeneratedBy.Increment();

            Map(x => x.DatumZakljucenja, "datum_zakljucenja").Not.Nullable();
            Map(x => x.PeriodVazenja, "period_vazenja");
            Map(x => x.TipOsiguranja, "tip_osiguranja");
            Map(x => x.Status, "status");
            Map(x => x.OsnovnaPremija, "osnovna_premija");
            Map(x => x.Valuta, "valuta");
            Map(x => x.NacinPlacanja, "nacin_placanja");
            Map(x => x.TipPolise, "tip_polise");

            References(x => x.VlasnikPolise, "id_vlasnika_polise");
            References(x => x.Agent, "id_angazovane_osobe");

            HasMany(x => x.IstorijaIzmena).KeyColumn("broj_polise").Cascade.AllDeleteOrphan().Inverse();
            HasMany(x => x.DodatnaPokrica).KeyColumn("broj_polise_dodatno").Cascade.AllDeleteOrphan().Inverse();
        }
    }
}