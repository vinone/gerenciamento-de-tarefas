var grid = $("#tarefas-grid-js");

$(document).ready(function (){
	
	
	$("#main-form .btn-primary").click(function(){
		$.ajax({
            url: "Tarefa/Listar",
            type: "POST",
            data: $(this).serialize(),
            contentType: 'application/json; charset=utf-8',
            success: function (data) {
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
            	adicionarConteudoAoGrid(html);
            }
        });
	});
});


function adicionarConteudoAoGrid(html){
	 grid.append(html);
};