using System;
using System.Linq;
using System.Collections.Generic;
using NHibernate;
using WebTasks.Core;

namespace WebTasks.Data
{
	public class Tarefas : ITarefas
	{
		private readonly ISession _session;
		public Tarefas(ISession session)
		{
			_session = session;
		}

		public IEnumerable<Tarefa> ConsultarPelaData (DateTime data)
		{
			return _session.QueryOver<Tarefa>()
				.Where(x => x.Quando == data)
					.List()
					.AsEnumerable();
		}

		public Tarefa Obter (int id)
		{
			return _session.Get<Tarefa>(id);
		}

		public void Salvar (Tarefa tarefa)
		{
			_session.SaveOrUpdate(tarefa);
		}

		public void Cancelar (Tarefa tarefa)
		{
			_session.Delete(tarefa);
		}
	}
}

