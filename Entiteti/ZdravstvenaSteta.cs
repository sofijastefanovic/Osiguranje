using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class ZdravstvenaSteta : Steta
    {
        public virtual string ZdravstvenaDokumenta { get; set; }
        public virtual string ZdravstvenaUstanova { get; set; }
    }
}
