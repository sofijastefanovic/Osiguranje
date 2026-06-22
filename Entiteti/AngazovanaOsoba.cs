using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class AngazovanaOsoba 
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Kontakt { get; set; }
        public virtual DateTime DatumAngazovanja { get; set; }
        public virtual string Status { get; set; }
        public virtual string TipOsobe { get; set; }
    }
}
