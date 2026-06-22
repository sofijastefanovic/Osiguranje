using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class JavnaInstitucija : Klijent
    {
        public virtual string Pib { get; set; }
        public virtual string MaticniBroj { get; set; }
        public virtual string Delatnost { get; set; }
        public virtual string KontaktOsobe { get; set; }
        public virtual string VrstaInstitucije { get; set; }
    }
}
