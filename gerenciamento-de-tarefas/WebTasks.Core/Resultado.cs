using System;

namespace WebTasks.Core
{
	public class Resultado
	{
		protected Resultado(){}

		public Resultado (string observacao, DateTime conclusao)
		{
			Observacao = observacao;
			Conclusao = conclusao;
		}

		protected int Id {get; set;}
		public string Observacao {get; protected set;}
		public DateTime Conclusao {get; protected set;}
	}
}

