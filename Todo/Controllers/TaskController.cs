using MediatR;
using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Data.Command;
using Todo.DTO;
using Todo.Models;

namespace Todo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private IMediator _mediator;

        public TaskController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<TaskController>
        [HttpGet]
        public async Task<List<TodoItem>> TodoList()
        {
            var todoList = await _mediator.Send(new GetTodoListQuery());
            return todoList;
        }

        // GET: api/<TaskController>/5
        [HttpGet("{id}")]
        public async Task<TodoItem> TodoById(int id)
        {
            var todoitem = await _mediator.Send(new GetTodoByIdQuery() { Id = id });
            return todoitem;
        }

        // POST api/<TaskController>
        [HttpPost]
        public async Task<TodoItem> AddTodo(CreateTodoItemDto todoItem)
        {
            var item = await _mediator.Send(new CreateTodoCommand(todoItem.Title, todoItem.Description, todoItem.Completed, todoItem.DueDate, DateTime.Now)) ;
            return item;
        }

        // PUT api/<TaskController>/5
        [HttpPut]
        public async Task<int> UpdateTodo(UpdateTodoItemDto todoItem)
        {
            var item = await _mediator.Send(new UpdateTodoCommand(todoItem.Id, todoItem.Title, todoItem.Description, todoItem.Completed, todoItem.DueDate, DateTime.Now));
            return item;
        }

        // DELETE api/<TaskController>/5
        [HttpDelete("{id}")]
        public async Task<int> DeleteTodo(int id)
        {
            return await _mediator.Send(new DeleteTodoCommand() { Id = id});
        }
    }
}
