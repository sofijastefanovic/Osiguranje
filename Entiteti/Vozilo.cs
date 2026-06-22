using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class Vozilo : PredmetOsiguranja
    {
        public virtual string Registracija { get; set; }
        public virtual string Marka { get; set; }
        public virtual string Model { get; set; }
        public virtual int GodinaProizvodnje { get; set; }
        public virtual string ImeVlasnika { get; set; }
        public virtual string PrezimeVlasnika { get; set; }
        public virtual Polisa AutoPolisa { get; set; }
    }
}
