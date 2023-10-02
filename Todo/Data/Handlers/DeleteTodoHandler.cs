using MediatR;
using Todo.Data.Command;
using Todo.Services;

namespace Todo.Data.Handlers
{
    public class DeleteTodoHandler : IRequestHandler<DeleteTodoCommand, int>
    {
        private readonly ITaskRepository _taskRepository;
        public DeleteTodoHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<int> Handle(DeleteTodoCommand request, CancellationToken cancellationToken)
        {
            var todoitem = await _taskRepository.GetTaskByIdAsync(request.Id);

            if (todoitem == null) return default;

            return await _taskRepository.DeleteTaskAsync(request.Id);
        }
    }
}
