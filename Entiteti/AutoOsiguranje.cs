using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class AutoOsiguranje : Polisa
    {
        public virtual int BonusMalusKlasa { get; set; }
        public virtual string TeritorijalnoVazenje { get; set; }
    }
}
