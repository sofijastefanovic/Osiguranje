using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class FazaObradeStete
    {
        public virtual int RedniBrojFaze { get; set; }
        public virtual DateTime DatumPocetka { get; set; }
        public virtual DateTime DatumZavrsetka { get; set; }
        public virtual string OdgovornoLice { get; set; }
        public virtual string Odluka { get; set; }
        public virtual string PotrebnaDokumenta { get; set; }

        //vezaa
        public virtual Steta Steta { get; set; }
    }
}
