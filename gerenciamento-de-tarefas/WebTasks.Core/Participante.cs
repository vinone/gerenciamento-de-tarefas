using System;

namespace WebTasks.Core
{
	public class Participante
	{
		protected Participante(){}
		public Participante (string nome, string email)
		{
			Nome = nome;
			Email = email;
		}

		public int Identificacao {get; protected set;}
		public string Nome {get; protected set;}
		public string Email {get; protected set;}
	}
}

