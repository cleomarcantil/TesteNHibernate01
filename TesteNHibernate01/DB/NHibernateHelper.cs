using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace TesteNHibernate01.DB
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure();
					//configuration.AddAssembly(typeof(Program).Assembly);

					AddAttributeMappings(configuration);

                    _sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

		private static void AddAttributeMappings(Configuration nhConfiguration)
		{
			var hbmSerializer = new HbmSerializer { Validate = true };

			//hbmSerializer.Serialize(typeof(Program).Assembly, "nhmap.xml");

			using (var stream = hbmSerializer.Serialize(typeof(Program).Assembly))
			{
				Debug.Write(stream);
				nhConfiguration.AddInputStream(stream);
			}
		}

	}
}
