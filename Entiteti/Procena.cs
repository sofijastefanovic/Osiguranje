using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class Procena
    {
        public virtual ProcenaId Id { get; set; }
        public virtual DateTime DatumProcene { get; set; }
        public virtual string MetodProcene { get; set; }
        public virtual string Nalaz { get; set; }
        public virtual string Preporuka { get; set; }
        public virtual decimal ProcenjeniIznos { get; set; }

        public Procena()
        {
            Id = new ProcenaId();
        }
    }
}
