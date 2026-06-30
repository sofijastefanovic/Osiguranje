using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class FazaObradeSteteMap : ClassMap<FazaObradeStete>
    {
        public FazaObradeSteteMap()
        {
            Table("FAZA_OBRADE_STETE");

            Id(x => x.RedniBrojFaze, "redni_broj_faze").GeneratedBy.SequenceIdentity();

            Map(x => x.DatumPocetka, "datum_pocetka").Not.Nullable();
            Map(x => x.DatumZavrsetka, "datum_zavrsetka").Not.Nullable();
            Map(x => x.OdgovornoLice, "odgovorno_lice");
            Map(x => x.Odluka, "odluka");
            Map(x => x.PotrebnaDokumenta, "potrebna_dokumenta");

            References(x => x.Steta, "id_stete");
        }
    }
}
