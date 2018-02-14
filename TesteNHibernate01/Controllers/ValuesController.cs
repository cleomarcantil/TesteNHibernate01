using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteNHibernate01.DB;

namespace TesteNHibernate01.Controllers
{
	[Route("api/[controller]")]
	public class ValuesController : Controller
	{
		// GET api/values
		[HttpGet]
		public object Get()
		{
			using (var session = NHibernateHelper.OpenSession())
			//using (var transaction = session.BeginTransaction())
			{
				var p = session.Get<Pessoa>(3);
				
				//session.Save(product);
				//transaction.Commit();


				return p;
			}

			//return "ok";
		}

		void teste()
		{
			object a = 1;

			switch (a)
			{
				case int x:
					
					break;

				default:
					break;
			}


		}

	}

}
