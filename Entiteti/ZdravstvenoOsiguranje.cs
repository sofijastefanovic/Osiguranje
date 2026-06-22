using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class ZdravstvenoOsiguranje : Polisa
    {
        public virtual string MrezaUstanove { get; set; }
        public virtual decimal GodisnjiLimit { get; set; }
    }
}
