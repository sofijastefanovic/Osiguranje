using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class Steta
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumPrijave { get; set; }
        public virtual DateTime DatumNastanka { get; set; }
        public virtual string VrstaStete { get; set; }
        public virtual string OpisDogadjaja { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual string StatusPostupka { get; set; }
        public virtual decimal ProcenjeniIznos { get; set; }

        //veze
        public virtual Klijent OstecenoLice { get; set; }
        public virtual Polisa Polisa { get; set; }
        public virtual PredmetOsiguranja PredmetOsiguranja { get; set; }
    }
}
