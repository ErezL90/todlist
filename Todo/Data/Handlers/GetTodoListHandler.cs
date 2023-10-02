using MediatR;
using Todo.Models;
using Todo.Services;

namespace Todo.Data.Handlers
{
    public class GetTodoListHandler : IRequestHandler<GetTodoListQuery, List<TodoItem>>
    {
        private readonly ITaskRepository _taskRepository;

        public GetTodoListHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<List<TodoItem>> Handle(GetTodoListQuery request, CancellationToken cancellationToken)
        {
            return await _taskRepository.GetTaskListAsync();
        }
    }
}
