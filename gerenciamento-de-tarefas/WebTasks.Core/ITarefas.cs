using System;
using System.Linq;
using System.Collections.Generic;

namespace WebTasks.Core
{
	public interface ITarefas
	{
		IEnumerable<Tarefa> ConsultarPelaData(DateTime data);
		Tarefa Obter(int id);
		void Salvar(Tarefa tarefa);
		void Cancelar(Tarefa tarefa);
	}
}

