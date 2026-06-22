using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class Procenitelj : AngazovanaOsoba
    {
        public virtual string Licensa { get; set; }
        public virtual string TipProcenitelja { get; set; }
    }
}
