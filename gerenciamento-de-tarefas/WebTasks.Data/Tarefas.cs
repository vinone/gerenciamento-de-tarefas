using System;
using System.Collections.Generic;
using WebTasks.Core;

namespace WebTasks.Data
{
	public class Tarefas : ITarefas
	{
		public IEnumerable<Tarefa> ConsultarDeHoje ()
		{
			throw new System.NotImplementedException ();
		}

		public IEnumerable<Tarefa> ConsultarDeAmanha ()
		{
			throw new System.NotImplementedException ();
		}

		public IEnumerable<Tarefa> ConsultarDosProximos7Dias ()
		{
			throw new System.NotImplementedException ();
		}

		public IEnumerable<Tarefa> ConsultarPorData (DateTime data)
		{
			throw new System.NotImplementedException ();
		}

		public Tarefa Obter (int id)
		{
			throw new System.NotImplementedException ();
		}

		public void Salvar (Tarefa tarefa)
		{
			throw new System.NotImplementedException ();
		}

		public void Cancelar (Tarefa tarefa)
		{
			throw new System.NotImplementedException ();
		}
	}
}

