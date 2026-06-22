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
        public NekretninaMap() {
            KeyColumn("Id");
            Map(x => x.Adresa);
            Map(x => x.TipObjekta);
            Map(x => x.GodinaIzgradnje);
            Map(x => x.Povrsina);
            Map(x => x.ProcenjenaVrednost);
        }
    }
}
