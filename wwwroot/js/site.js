var token = $('meta[name="csrf-token"]').attr('content');

$.ajax({
    url: '/Tarefas/MarcarConcluida',
    type: 'POST',
    contentType: 'application/json',
    headers: {
        'RequestVerificationToken': token
    },
    data: JSON.stringify({ id: tarefaId, concluida: true }),
    success: function () {
        alert('Tarefa marcada com sucesso!');
    },
    error: function () {
        alert('Erro ao marcar a tarefa.');
    }
});

