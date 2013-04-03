using System;
using System.Collections.Generic;
using WebTasks.Core;

namespace gerenciamentodetarefas
{
	public class TarefasMock : ITarefas
	{
		public IEnumerable<Tarefa> ConsultarPelaData (DateTime data)
		{
			return new List<Tarefa>
			{
				new Tarefa("Estudar Ruby", DateTime.Now),
				new Tarefa("Pagar mensalidade",DateTime.Now),
				new Tarefa("Terminar freela", DateTime.Now.AddDays(1)),
				new Tarefa("Enviar email p/ fulano", DateTime.Now.AddDays(1)),
				new Tarefa("Entregar trabalho", DateTime.Now.AddDays(7)),
				new Tarefa("Comprar presente Mãe", DateTime.Now.AddDays(7))
			};
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

