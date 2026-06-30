using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class StetaMap : ClassMap<Steta>
    {
        public StetaMap()
        {
            Table("STETA");

            Id(x => x.Id, "id").GeneratedBy.SequenceIdentity();

            Map(x => x.DatumPrijave, "datum_prijave").Not.Nullable();
            Map(x => x.DatumNastanka, "datum_nastanka").Not.Nullable();
            Map(x => x.VrstaStete, "vrsta_stete");
            Map(x => x.OpisDogadjaja, "opis_dogadjaja");
            Map(x => x.Lokacija, "lokacija");
            Map(x => x.StatusPostupka, "status_postupka");
            Map(x => x.ProcenjeniIznos, "procenjeni_iznos");

            References(x => x.OstecenoLice, "id_ostecenog_lica");
            References(x => x.Polisa, "id_polise");
            References(x => x.PredmetOsiguranja, "id_predmet_osiguranja");
        }
    }
}
