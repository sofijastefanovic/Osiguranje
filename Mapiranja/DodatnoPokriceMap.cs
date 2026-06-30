using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;


namespace Osiguranje.Mapiranja
{
    internal class DodatnoPokriceMap : ClassMap<DodatnoPokrice>
    {
        public DodatnoPokriceMap()
        {
            Table("DODATNO_POKRICE");

            // redni_broj je identity u bazi, zato koristimo Identity()
            Id(x => x.RedniBroj, "redni_broj").GeneratedBy.SequenceIdentity();

            Map(x => x.Naziv, "naziv");
            Map(x => x.Opis, "opis");
            Map(x => x.Limit, "limit_iznos");
            Map(x => x.Fransiza, "fransiza");
            Map(x => x.DodatnaPremija, "dodatna_premija");

            // Veza ka Polisi
            References(x => x.Polisa, "broj_polise_dodatno");
        }
    }
}
