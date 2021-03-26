using System;
using Todo.Domain.Entities;
using Xunit;

namespace Todo.Domain.Tests.EntityTests
{
    public class TodoItemsTests
    {
        private readonly TodoItem _todo = new TodoItem("Título do todo", DateTime.Now, "edivaldopacheco");
        [Fact]
        public void Dado_um_novo_todo_o_mesmo_nao_pode_ser_concluido()
        {
            Assert.False(_todo.Done);
        }
    }
}