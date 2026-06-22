using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class FizickoLice : Klijent
    {
        public virtual string Jmbg { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string Zanimanje { get; set; }
    }
}
