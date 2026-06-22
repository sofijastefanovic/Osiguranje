using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class ZivotnoOsiguranje : Polisa
    {
        public virtual string TipIsplate { get; set; }
        public virtual decimal SumaOsiguranja { get; set; }
    }
}
