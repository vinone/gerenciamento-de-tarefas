using System;
using WebTasks.Core;
using FluentNHibernate.Mapping;

namespace WebTasks.Data
{
	public class TarefaMap : ClassMap<Tarefa>
	{
		protected TarefaMap ()
		{
			Table("TAREFAS");
			Id ();
			Map(x => x.Descricao,"DESCRICAO");
			Map(x => x.Quando,"DT_QUANDO");
			References<Resultado>(x => x.Resultado,"ID_RESULTADO")
				.Cascade
				.All();
		}
	}
}

