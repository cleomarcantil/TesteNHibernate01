using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteNHibernate01.DB
{
	[JoinedSubclass(Table = "usuarios", ExtendsType = typeof(Pessoa), Lazy = true)]
	[Key(Column = "Id")]
	public class Usuario : Pessoa
    {
		[Property]
		public virtual string Login { get; set; }

		[Property]
		public virtual string Senha { get; set; }

	}
}
