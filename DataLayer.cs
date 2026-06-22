using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate;
using Osiguranje.Entiteti;
using NHibernate;

namespace Osiguranje
{
    public class DataLayer
    {
        private static ISessionFactory _factory = null;
        public static ISession GetSession()
        {
            if(_factory == null)
            {
                _factory = Fluently.Configure()
                    .Database(OracleClientConfiguration.Oracle10
                    .ConnectionString("Data Source=localhost;User Id=S19943;Password=jagodicaBoobica"))
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Polisa>())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Klijent>())
                    .BuildSessionFactory();
            }
            return _factory.OpenSession();
        }

    }
}
