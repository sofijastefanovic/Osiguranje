using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class Usev : PredmetOsiguranja
    {
        public virtual string Vrsta { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual decimal ProcenjenaVrednost { get; set; }
    }
}
