using Microsoft.Extensions.Logging;
using NSubstitute;
using ToDoAPI.Controllers;
using ToDoAPI.Models;
using ToDoAPI.Repositories.Interfaces;

namespace UnitTests.Controllers
{
    public class ToDoControllerTests
    {
        private ILogger<ToDoController> subLogger;
        private IRepository<ToDo> subRepository;

        public ToDoControllerTests()
        {
            this.subLogger = Substitute.For<ILogger<ToDoController>>();
            this.subRepository = Substitute.For<IRepository<ToDo>>();
        }

        private ToDoController CreateToDoController()
        {
            return new ToDoController(
                this.subLogger,
                this.subRepository);
        }

        [Fact]
        public void GetAll_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
