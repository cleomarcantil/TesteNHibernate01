using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteNHibernate01.DB
{
	[Class(Table = "pessoas", Lazy = true, Abstract = true)]
    public abstract class Pessoa
    {
		[Id(Name = "Id", TypeType = typeof(int))]
		[Generator(1, Class = "identity")]
		public virtual int Id { get; set; }

		[Property]
		public virtual string Nome { get; set; }

    }
}
