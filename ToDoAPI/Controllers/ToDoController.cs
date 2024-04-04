using Microsoft.AspNetCore.Mvc;
using ToDoAPI.Models;
using ToDoAPI.Repositories.Interfaces;

namespace ToDoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly ILogger<ToDoController> _logger;
        private readonly IRepository<ToDo> _todoRepository;

        public ToDoController(
            ILogger<ToDoController> logger,
            IRepository<ToDo> todoRepository)
        {
            _logger = logger;
            _todoRepository = todoRepository;
        }

        // TODO use ActionResult to return 
        [HttpGet]
        public IEnumerable<ToDo> GetAll()
        {
            _logger.LogInformation("All todos called");
            return _todoRepository.GetAll();
        }

        // TODO Add other CRUD Endpoints
    }
}