using MediatR;
using Todo.Models;
using Todo.Services;

namespace Todo.Data.Handlers
{
    public class GetTodoHandler : IRequestHandler<GetTodoByIdQuery, TodoItem>
    {
        private readonly ITaskRepository _taskRepository;

        public GetTodoHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }


        public async Task<TodoItem> Handle(GetTodoByIdQuery request, CancellationToken cancellationToken)
        {
            return await _taskRepository.GetTaskByIdAsync(request.Id);

        }
    }
}
