using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class Putovanje : PredmetOsiguranja
    {
        public virtual int PeriodPutovanja { get; set; }
    }
}
