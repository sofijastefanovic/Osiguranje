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
using System.Windows.Forms; // OBAVEZNO DODATO ZA MESSAGEBOX

namespace Osiguranje
{
    public class DataLayer
    {
        private static ISessionFactory _factory = null;

        public static ISession GetSession()
        {
            try
            {
                if (_factory == null)
                {
                    _factory = Fluently.Configure()
                        .Database(OracleManagedDataClientConfiguration.Oracle10
                            .Driver<NHibernate.Driver.OracleManagedDataClientDriver>()
                            .ConnectionString("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S19943;Password=jagodicaBoobica")
                            .ShowSql())
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Osiguranje.Mapiranja.KlijentMap>())
                        .BuildSessionFactory();
                }
                return _factory.OpenSession();
            }
            catch (Exception ex)
            {
                // Izgradnja detaljne poruke o greski kroz sve InnerException nivoe
                string poruka = "NHibernate Inicijalizacija Pukla!\n\n[Glavna greska]: " + ex.Message;

                if (ex.InnerException != null)
                {
                    poruka += "\n\n[Sloj 1]: " + ex.InnerException.Message;

                    if (ex.InnerException.InnerException != null)
                    {
                        poruka += "\n\n[Sloj 2 (Glavni uzrok)]: " + ex.InnerException.InnerException.Message;

                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            poruka += "\n\n[Sloj 3]: " + ex.InnerException.InnerException.InnerException.Message;
                        }
                    }
                }

                // Prikazujemo skoci-prozor sa kompletnim detaljima
                MessageBox.Show(poruka, "KRITIČNA GREŠKA U MAPIRANJU", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Vracamo null ili ponovo bacamo izuzetak da program zna da je puklo
                throw;
            }
        }
    }
}