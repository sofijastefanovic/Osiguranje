using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class AutoSteta : Steta
    {
        public virtual string ZapisnikPolicije { get; set; }
        public virtual string Servis { get; set; }

        public virtual Steta Steta { get; set; }
    }
}
