using System;
using System.Collections.Generic;

namespace WebTasks.Core
{
	public interface ITarefas
	{
		IEnumerable<Tarefa> ConsultarDeHoje();
		IEnumerable<Tarefa> ConsultarDeAmanha();
		IEnumerable<Tarefa> ConsultarDosProximos7Dias();
		IEnumerable<Tarefa> ConsultarPorData(DateTime data);
		Tarefa Obter(int id);
		void Salvar(Tarefa tarefa);
		void Cancelar(Tarefa tarefa);
	}
}

