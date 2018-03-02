using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
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
			var rnd = new Random();

			using (var session = NHibernateHelper.OpenSession())
			//using (var transaction = session.BeginTransaction())
			{
				var c = rnd.Next();
				AddCliente(session, $"Cliente {c}", $"{c, -10}");

				var u = rnd.Next();
				AddUsuario(session, $"Usuário {u}", $"usuario-{u}", $"s{u}");

				//var p = session.Get<Pessoa>(3);
				var ps = session.QueryOver<Pessoa>()
					.List();


				//transaction.Commit();

				return ps;
			}

			//return "ok";
		}

		void AddUsuario(ISession session, string nome, string login, string senha)
		{
			var p = new Usuario() {
				Nome = nome,
				Login = login,
				Senha = senha,
			};

			session.Save(p);
		}

		void AddCliente(ISession session, string nome, string cpf)
		{
			var c = new Cliente()
			{
				Nome = nome,
				CPF = cpf,
			};

			session.Save(c);
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
