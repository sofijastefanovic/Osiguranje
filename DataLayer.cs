using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using Osiguranje.Entiteti;
using Osiguranje.Mapiranja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje
{
    public class DataLayer
    {
        private static ISessionFactory _factory = null;

        public static ISession GetSession()
        {
            if (_factory == null)
            {
                _factory = Fluently.Configure()
                    .Database(OracleDataClientConfiguration.Oracle10
                        .Driver<NHibernate.Driver.OracleManagedDataClientDriver>()
                        .ConnectionString("Data Source=localhost;User Id=S19943;Password=jagodicaBoobica")
                        .ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Osiguranje.Mapiranja.KlijentMap>())
                    .BuildSessionFactory();
            }
            return _factory.OpenSession();
        }
    }
}