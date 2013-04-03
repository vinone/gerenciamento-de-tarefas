using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using WebTasks.Data;
using WebTasks.Core;
using FluentNHibernate;

namespace gerenciamentodetarefas
{
	public class TarefaController : Controller
	{
		private ITarefas _tarefas;

		public ViewResult Index()
		{
			return View();
		}

		[HttpPost]
		public JsonResult Listar(string data)
		{
			//Para testar
//			var model = new TarefaModelSearch(new TarefasMock());
//
//			return Json(model.ConsultarPeloFiltro(), 
//			            JsonRequestBehavior.AllowGet);

			using(var session = DataContext.SessionFactory.OpenSession())
			{
				_tarefas = new Tarefas(session);
				var model = new TarefaModelSearch(_tarefas)
				{
					Data = Convert.ToDateTime(data)
				};

				return Json(model.ConsultarPeloFiltro(), 
			            JsonRequestBehavior.AllowGet);
			}
		}

		[HttpPost]
		public JsonResult Criar(string descricao, string data)
		{
			//Para testar
//			return Json(new { Mensagem = "OK! A sua tarefa foi agendada."}, 
//			            JsonRequestBehavior.AllowGet);

			using(var session = DataContext.SessionFactory.OpenSession())
			{
				_tarefas = new Tarefas(session);
				new TarefaModelCreate(_tarefas)
				{
					Descricao = descricao,
					PrevisaoConclusao = Convert.ToDateTime(data)
				}.Criar();

			
				return Json(new { Mensagem = "OK! A sua tarefa foi agendada."}, 
			            JsonRequestBehavior.AllowGet);
			}
		}

		private DataAccessProvider DataContext
		{
			get
			{
				return new DataAccessProvider(MainConnectionString);
			}
		}

		private string MainConnectionString
		{
			get 
			{
				return ConfigurationManager
					.ConnectionStrings["main_connection"].ConnectionString;
			}
		}
	}
}

