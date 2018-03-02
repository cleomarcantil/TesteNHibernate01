using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteNHibernate01.DB
{
	[JoinedSubclass(Table = "clientes", ExtendsType = typeof(Pessoa), Lazy = true)]
	[Key(Column = "Id")]
	public class Cliente : Pessoa
    {
		[Property]
		public virtual string CPF { get; set; }

	}
}
