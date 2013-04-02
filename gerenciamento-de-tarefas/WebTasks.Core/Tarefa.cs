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

		public int Identificacao {get; protected set;}
		public string Descricao {get; protected set;}
		public DateTime Quando {get; protected set;}

		private List<Participante> _participantes;
		public IEnumerable<Participante> Participantes 
		{
			get { return _participantes;} 
			protected set { _participantes = (List<Participante>)value;}
		}
		public Resultado Resultado {get; protected set;}

		public void IncluirParticipante(Participante participante)
		{
			if(participante == null) return;

			if(Participantes == null)
				_participantes = new List<Participante>{ participante};

			if(_participantes.Contains(participante)) return;

			_participantes.Add(participante);
		}

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

