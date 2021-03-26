using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Domain.Entities;
using Todo.Domain.Queries;
using Xunit;

namespace Todo.Domain.Tests.QueryTests
{
    public class TodoQueryTests
    {
        private IList<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 2", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 3", DateTime.Now, "edivaldopacheco"));
            _items.Add(new TodoItem("Tarefa 4", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 5", DateTime.Now, "edivaldopacheco"));
        }

        [Fact]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario_informado()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("edivaldopacheco"));
            Assert.Equal(2, result.Count());

        }
    }
}