var grid = $("#tarefas-grid-js");

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
});

function submitForm(date){
	$.post("Tarefa/Listar", 
			{data: date}, 
			function (data) {
    			preencherGrid(data);
    		});
}

function preencherGrid(data){
	var html = "";
	for(var i = 0, qtde = data.length;i<qtde;i++){
		html += '<tr>';
		html += '<td>' + data[i].Descricao + '</td>';
		html += '<td>' + data[i].Quando + '</td>';
		html += '<td>';
		for(var y = 0, current = data[i],len = current.Participantes.length;y<len;y++){
			html += current.Participantes[y].Nome + ' / ' + current.Participantes[y].Email + ' ;<br />';
		}
		html += '<td>' + data[i].Concluida + '</td>';
		html += '</tr>';
	}
 	grid.append(html);
}