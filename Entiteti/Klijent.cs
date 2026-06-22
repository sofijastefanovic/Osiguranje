using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class Klijent
    {
        public virtual int Id { get; set; }
        public virtual string ImePrezimeNaziv { get; set; }
        public virtual DateTime DatumRegistracije { get; set; }
        public virtual string StatusKlijenata { get; set; }
        public virtual string Ulica { get; set; }
        public virtual string Broj { get; set; }

        // nije u tabeli al su posebne tabele pa da se poveze
        public virtual IList<string> Emailovi { get; set; }
        public virtual IList<string> Telefoni { get; set; }

        //da ne bi bile liste null
        public Klijent()
        {
            Emailovi = new List<string>();
            Telefoni = new List<string>();
        }
    }
}
