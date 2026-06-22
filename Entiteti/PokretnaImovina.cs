using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class PokretnaImovina : PredmetOsiguranja
    {
        public virtual string SerijskiBroj { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Opis { get; set; }
        public virtual decimal ProcenjenaVrednost { get; set; }
    }
}
