using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;

namespace Osiguranje.Mapiranja
{
    internal class PolisaMap : ClassMap<Polisa>
    {
        public PolisaMap()
        {
            // 1. OBAVEZNO DOSLOVNO IME TABELE VELIKIM SLOVIMA (Da izbegnemo ORA-00942)
            Table("POLISA");

            // 2. Primarni ključ (Proveri da li je u bazi BROJ_POLISE ili samo ID)
            Id(x => x.BrojPolise, "BROJ_POLISE").GeneratedBy.TriggerIdentity();

            // 3. Mapiranje običnih kolona (Usklađeno sa velikim slovima iz Oracle-a)
            Map(x => x.PeriodVazenja, "PERIOD_VAZENJA");
            Map(x => x.TipOsiguranja, "TIP_OSIGURANJA");
            Map(x => x.Status, "STATUS");
            Map(x => x.OsnovnaPremija, "OSNOVNA_PREMIJA");
            Map(x => x.Valuta, "VALUTA");
            Map(x => x.NacinPlacanja, "NACIN_PLACANJA");
            Map(x => x.TipPolise, "TIP_POLISE");
            Map(x => x.DatumZakljucenja, "DATUM_ZAKLJUCENJA").Not.Nullable();

            // 4. Strani ključevi (Veze) - moraju da gađaju tačna imena kolona u bazi
            // Ako ti se u bazi kolone zovu ID_VLASNIKA i ID_AGENTA, promeni ovde navodnike!
            References(x => x.VlasnikPolise, "ID_VLASNIKA");
            References(x => x.Agent, "ID_AGENTA");

            // 5. Kolekcije / Liste (Gledajući tvoj SQL upit za podklase, ključ spajanja treba da bude BROJ_POLISE)
            HasMany(x => x.IstorijaIzmena).KeyColumn("BROJ_POLISE").Cascade.AllDeleteOrphan().Inverse();
            HasMany(x => x.DodatnaPokrica).KeyColumn("BROJ_POLISE").Cascade.AllDeleteOrphan().Inverse();
        }
    }
}