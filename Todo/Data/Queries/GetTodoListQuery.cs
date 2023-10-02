using MediatR;
using Todo.Models;

namespace Todo.Data
{
    public class GetTodoListQuery : IRequest<List<TodoItem>>
    {
    }
}
