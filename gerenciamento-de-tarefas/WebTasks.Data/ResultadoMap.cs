using System;
using WebTasks.Core;
using FluentNHibernate.Mapping;

namespace WebTasks.Data
{
	public class ResultadoMap : ClassMap<Resultado>
	{
		protected ResultadoMap ()
		{
			Table("RESULTADOS");
			Id ();
			Map (x => x.Observacao,"OBSERVACAO");
			Map (x => x.Conclusao,"DT_CONCLUSAO");
		}
	}
}

