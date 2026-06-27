using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    // PROMENJENO: Umesto ClassMap<FizickoLice> sada je SubclassMap<FizickoLice>
    internal class FizickoLiceMap : SubclassMap<FizickoLice>
    {
        public FizickoLiceMap()
        {
            // 1. Naziv tabele u Oracle bazi za fizicka lica
            Table("FIZICKO_LICE");

            // 2. Primarni ključ koji je ujedno i strani ključ ka tabeli KLIJENT
            // Zameni "ID_KLIJENTA" sa tačnim nazivom kolone iz tvoje baze ako se zove drugačije (npr. ID)
            KeyColumn("ID_KLIJENTA");

            // 3. Mapiranje ostalih specifičnih polja
            Map(x => x.Jmbg, "JMBG"); // Dobra praksa je staviti naziv kolone pod navodnike (velika slova zbog Oracle-a)
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA").Not.Nullable();
            Map(x => x.Zanimanje, "ZANIMANJE");
        }
    }
}