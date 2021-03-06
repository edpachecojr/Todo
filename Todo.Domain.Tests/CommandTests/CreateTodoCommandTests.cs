using System;
using Todo.Domain.Commands;
using Xunit;

namespace Todo.Domain.Tests.CommandTests
{
    public class CreateTodoCommandTests
    {

        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Titulo todo", "edivaldopacheco", DateTime.Now);

        [Fact]
        public void Dado_um_comando_invalido()
        {

            _invalidCommand.Validate();
            Assert.False(_invalidCommand.Valid);
        }

        [Fact]
        public void Dado_um_comando_valido()
        {

            _validCommand.Validate();
            Assert.True(_validCommand.Valid);
        }
    }
}
