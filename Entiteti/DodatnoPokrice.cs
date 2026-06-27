using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class DodatnoPokrice
    {
        public virtual Polisa Polisa { get; set; }
        public virtual int RedniBroj { get; set; }

        public virtual string Naziv { get; set; }
        public virtual string Opis { get; set; }
        public virtual decimal Limit { get; set; }
        public virtual decimal Fransiza { get; set; }
        public virtual decimal DodatnaPremija { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            var target = (DodatnoPokrice)obj;
            return (Polisa?.BrojPolise == target.Polisa?.BrojPolise) && (RedniBroj == target.RedniBroj);
        }

        public override int GetHashCode()
        {
            return (Polisa?.BrojPolise ?? 0).GetHashCode() ^ RedniBroj.GetHashCode();
        }
    }
}
