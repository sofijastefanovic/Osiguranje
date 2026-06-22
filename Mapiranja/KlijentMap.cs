using FluentNHibernate.Mapping;
using Osiguranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Mapiranja
{
    internal class KlijentMap : ClassMap<Klijent>
    {
        public KlijentMap() {
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity();

            Map(x => x.ImePrezimeNaziv);
            Map(x => x.StatusKlijenata);
            Map(x => x.Ulica);
            Map(x => x.Broj);

            Map(x => x.DatumRegistracije, "DatumRegistracije").Not.Nullable();

            HasMany(x => x.Emailovi).Table("KlijentEmail").KeyColumn("Id")  
                .Element("emailovi").Cascade.All();

            HasMany(x => x.Telefoni)
                .Table("KlijentTelefon")     
                .KeyColumn("Id")      
                .Element("Telefoni")     
                .Cascade.All();
        }
    }
}
