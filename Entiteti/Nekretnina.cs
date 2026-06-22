using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class Nekretnina : PredmetOsiguranja
    {
        public virtual string Adresa { get; set; }
        public virtual string TipObjekta { get; set; }
        public virtual int GodinaIzgradnje { get; set; }
        public virtual decimal Povrsina { get; set; }
        public virtual decimal ProcenjenaVrednost { get; set; }
    }
}
