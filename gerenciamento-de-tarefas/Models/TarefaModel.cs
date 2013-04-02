using System;
using System.Collections.Generic;

namespace gerenciamentodetarefas
{
	public class TarefaModel
	{
		public int Id {get;set;}
		public string Descricao {get; set;}
		public string Quando {get;set;}
		public List<ParticipanteModel> Participantes {get; set;}
		public bool Concluida {get; set;}
	}

	public class TarefaModelSearch : TarefaModel
	{
		public DateTime Data {get; set;}

		public IEnumerable<TarefaModel> ConsultarTodos()
		{
			return new List<TarefaModel>{
				new TarefaModel{ 
					Id = 1,
					Descricao = "Estudar Ruby",
					Quando = "02/04/2013",
					Participantes = new List<ParticipanteModel>
					{
						new ParticipanteModel{ 
							Nome = "João José", 
							Email = "joao.jose@gmail.com"},
						new ParticipanteModel{ 
							Nome = "Maria Joao", 
							Email = "maria.joao@gmail.com"},
					},
					Concluida = false
				},
				new TarefaModel{ 
					Id = 2,
					Descricao = "Terminar freela",
					Quando = "02/04/2013",
					Participantes = new List<ParticipanteModel>{
							new ParticipanteModel{ 
							Nome = "Paulo Antonio", 
							Email = "paulo.antonio@gmail.com"},
					},
					Concluida = false
				},
				new TarefaModel{ 
					Id = 3,
					Descricao = "Pagar mensalidade",
					Quando = "02/04/2013",
					Participantes = new List<ParticipanteModel>(),
					Concluida = false
				}
			};
//			throw new System.NotImplementedException ();
		}

		public IEnumerable<TarefaModel> ConsultarPeloFiltro()
		{
			throw new System.NotImplementedException ();
		}
	}
}

