using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class Polisa
    {
        public virtual int BrojPolise { get; set; }
        public virtual DateTime DatumZakljucenja { get; set; }
        public virtual int PeriodVazenja { get; set; }
        public virtual string TipOsiguranja { get; set; }
        public virtual string Status { get; set; }
        public virtual decimal OsnovnaPremija { get; set; }
        public virtual string Valuta { get; set; }
        public virtual string NacinPlacanja { get; set; }
        public virtual string TipPolise { get; set; }

        // veze
        public virtual Klijent VlasnikPolise { get; set; }
        public virtual AngazovanaOsoba Agent { get; set; }
    }
}
