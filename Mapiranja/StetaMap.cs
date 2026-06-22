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
        public StetaMap() {
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumPrijave, "DatumPrijave").Not.Nullable();
            Map(x => x.DatumNastanka, "DatumNastanka").Not.Nullable();

            Map(x => x.VrstaStete);
            Map(x => x.OpisDogadjaja);
            Map(x => x.Lokacija);
            Map(x => x.StatusPostupka);
            Map(x => x.ProcenjeniIznos);

            References(x => x.OstecenoLice, "OstecenoLice");
            References(x => x.Polisa, "Polisa");
            References(x => x.PredmetOsiguranja, "PredmetOsiguranja");



        }
    }
}
