using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class IstorijaIzmenaPolisa
    {
        public virtual int Id { get; set; }
        public virtual string TipIzmene { get; set; }
        public virtual DateTime DatumIzmene { get; set; }
        public virtual string StaraVrednost { get; set; }
        public virtual string NovaVrednost { get; set; }

        public virtual Polisa Polisa { get; set; }
    }
}
