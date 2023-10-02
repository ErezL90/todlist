using MediatR;
using Todo.Models;

namespace Todo.Data
{
    public class GetTodoByIdQuery : IRequest<TodoItem>
    {
        public int Id { get; set; }
    }
}
