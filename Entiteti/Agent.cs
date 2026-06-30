using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class Agent : AngazovanaOsoba
    {
        public virtual string Licensa { get; set; }
        public virtual decimal Provizija { get; set; }
        public virtual string TipAgenta { get; set; }

        public virtual AngazovanaOsoba AngazovanaOsoba { get; set; }
    }
}
