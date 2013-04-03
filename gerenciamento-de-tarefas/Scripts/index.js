var grid = $("#tarefas-grid-js");
var alert = $(".alert");

$(document).ready(function (){
	$("#filter-form .btn").click(function(){
		var date = moment();
		var button_name = $(this).attr("name");
		
		switch(button_name){
			case "amanha": date = moment().add('d',1);
				break;
			case "proximos-7-dias": date = moment().add('d',7);
				break;
			case "custom-date": date = $("#date-js").val();
				break;
		}
		submitForm(date.format('L'));
	});
	
	$("#create-form .btn-primary").click(function(){
		isCreationValid(function(data){
			$.post("Tarefa/Criar",
				data,
				function(message){
					reloadGrid();
					appendMessage(message.Mensagem);
					toggleAlert(true,"alert-success");
					$("#create-form :input").each(function(e){
						$(this).val("");
					});
				});
			});
		});
});

function submitForm(date){
	$.post("Tarefa/Listar", 
			{data: date}, 
			function (data) {
    			preencherGrid(data);
    		});
}

function preencherGrid(data){
	grid.children("tbody").remove();
	var html = "";
	for(var i = 0, qtde = data.length;i<qtde;i++){
		html += '<tr>';
		html += '<td>' + data[i].Descricao + '</td>';
		html += '<td>' + data[i].Quando + '</td>';
		html += '<td>' +  ((data[i].Concluida == true) ? "SIM" : "NÃO") + '</td>';
		html += '</tr>';
	}
 	grid.append(html);
}

function reloadGrid(){
	submitForm(moment().format('L'));
}

function isCreationValid(callback){
		var descricao_input = $("#oque");
		var data_input = $("#quando");
		var descricao = descricao_input.val();
		var data = data_input.val();
		var status = false;

		if(descricao === ""){
			appendMessage("Descreva a tarefa...");
			notValid();
			status = false;
		}
		else if(data === ""){
			appendMessage("Informe a data de conclusão...");
			notValid();
			status = false;
		}
		else{
			valid();
			status =true;
		}
		
		if(status) 
			callback({descricao: descricao, data: data});
}

function appendMessage(message){
	$(".alert .message").empty();
	$(".alert .message").append(message);
}

function valid(){
	setAlertToSuccess();
	toggleAlert();
}

function notValid(){
	setAlertToError();
	toggleAlert(true);
}


function setAlertToSuccess(){
	alert.removeClass("alert-error")
		.addClass("alert-success");
}

function setAlertToError(){
	alert.removeClass("alert-success")
		.addClass("alert-error");
}

function toggleAlert(show){
	if(show)
		alert.removeClass("invisible")
			.addClass("visible");
	else
		alert.addClass("invisible")
			.removeClass("visible");
}