<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<link rel="stylesheet" href="~/Content/bootstrap/css/bootstrap.min.css" media="screen"></link>
	<title>webTasks - Gerenciamento de tarefas online</title>
</head>
<body>
	<div class="container">
		<h1>webTasks: Gerencie-se</h1>
		<div class="row-fluid">
			<form id="filter-form" method="post" class="form-inline">
				<a class="btn btn-primary btn-large" href="#" name="hoje">Hoje</a>
				<a class="btn btn-large" href="#" name="amanha">Amanhã</a>
				<a class="btn btn-large" href="#" name="proximos-7-dias">Próximos 7 dias</a>
				<input class="input-small" type="text" placeholder="dd/mm/aaaa" id="date-js"></input>
				<button class="btn" type="button" name="custom-date">Filtrar</button>
			</form>
		</div>
		
		<div class="row-fluid">
			<table class="table table-striped" id="tarefas-grid-js">
				<thead>
					<tr>
						<td>O que?</td>
						<td>Quando?</td>
						<td>Com quem?</td>
						<td>Pronto?</td>
					</tr>
				</thead>
			</table>
		</div>
		
		<div class="row-fluid">
			<form id="create-form" action="Tarefa/New" method="post" class="form-inline">
				<input class="input-small" type="text" placeholder="O que?" name="oque"></input>
				<input class="input-small" type="text" placeholder="Quando?" name="quando"></input>
				<input class="input-small" type="text" placeholder="Com quem?" name="comquem"></input>
				<button class="btn btn-primary" type="button">Criar</button>
			</form>
		</div>
	</div>
    
    <script src="http://code.jquery.com/jquery-1.9.1.min.js"></script>
	<script src="http://code.jquery.com/jquery-migrate-1.1.1.min.js"></script>
	<script src="https://raw.github.com/timrwood/moment/2.0.0/min/moment.min.js"></script>
	<script src="~/Scripts/index.js"></script>
</body>