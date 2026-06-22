using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class PredmetOsiguranja
    {
        public virtual int Id { get; set; }
        public virtual string TipPredmeta { get; set; }
    }
}
