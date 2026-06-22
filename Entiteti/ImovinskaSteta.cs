using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class ImovinskaSteta : Steta
    {
        public virtual decimal ProcenaOstecenja { get; set; }
    }
}
