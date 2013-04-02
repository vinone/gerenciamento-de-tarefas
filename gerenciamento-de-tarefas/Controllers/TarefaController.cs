using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace gerenciamentodetarefas
{
	public class TarefaController : Controller
	{
		public ViewResult Index()
		{
			return View();
		}

		[HttpPost]
		public JsonResult Listar(string data)
		{
			var model = new TarefaModelSearch
			{
				Data = Convert.ToDateTime(data)
			};

			return Json(model.ConsultarPeloFiltro(), 
			            JsonRequestBehavior.AllowGet);
		}
	}
}

