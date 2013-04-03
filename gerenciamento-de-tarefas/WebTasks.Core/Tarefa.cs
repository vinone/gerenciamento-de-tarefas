using System;
using System.Collections.Generic;

namespace WebTasks.Core
{
	public class Tarefa
	{
		protected Tarefa(){}
		public Tarefa (string descricao, DateTime quando)
		{
			Descricao = descricao;
			Quando = quando;
		}

		public int Id {get; protected set;}
		public string Descricao {get; protected set;}
		public DateTime Quando {get; protected set;}
		public Resultado Resultado {get; protected set;}

		public bool EstaConcluida 
		{
			get{
				return Resultado != null;
			}
		}

		public void Concluir(Resultado resultado)
		{
			if(resultado == null)
				return;

			Resultado = resultado;
		}
	}
}

