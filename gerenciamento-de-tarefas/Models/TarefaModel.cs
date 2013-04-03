using System;
using System.Collections.Generic;
using WebTasks.Core;

namespace gerenciamentodetarefas
{
	public class TarefaModel
	{
		public int Id {get;set;}
		public string Descricao {get; set;}
		public string Quando {get;set;}
		public bool Concluida {get; set;}
	}

	public class TarefaModelSearch : TarefaModel
	{
		private ITarefas _tarefas;
		public TarefaModelSearch(ITarefas tarefas)
		{
			_tarefas = tarefas;
		}

		public DateTime Data {get; set;}

		public IEnumerable<TarefaModel> ConsultarPeloFiltro()
		{
			var tarefas = new List<TarefaModel>();

			foreach (var tarefa in _tarefas.ConsultarPelaData(Data)) {
				tarefas.Add(new TarefaModel
	            {
					Id = tarefa.Id,
					Descricao = tarefa.Descricao,
					Concluida = tarefa.EstaConcluida,
					Quando = tarefa.Quando.ToShortDateString()
				});
			}

			return tarefas;
		}
	}

	public class TarefaModelCreate : TarefaModel
	{
		public DateTime PrevisaoConclusao {get;set;}
		private ITarefas _tarefas;
		public TarefaModelCreate(ITarefas tarefas)
		{
			_tarefas = tarefas;
		}

		public void Criar()
		{
			_tarefas.Salvar(new Tarefa(Descricao,PrevisaoConclusao));
		}
	}
}

