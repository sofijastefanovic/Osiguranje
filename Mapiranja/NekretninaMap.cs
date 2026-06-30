using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osiguranje.Mapiranja
{
    internal class NekretninaMap : SubclassMap<Nekretnina>
    {
        public NekretninaMap()
        {
            Table("NEKRETNINA");
            KeyColumn("id_predmeta");

            Map(x => x.Adresa, "adresa");
            Map(x => x.TipObjekta, "tip_objekta");
            Map(x => x.GodinaIzgradnje, "godina_izgradnje");
            Map(x => x.Povrsina, "povrsina");
            Map(x => x.ProcenjenaVrednost, "procenjena_vrednost");
        }
    }
}
