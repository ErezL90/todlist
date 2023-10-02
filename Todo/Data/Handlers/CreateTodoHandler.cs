using MediatR;
using Todo.Data.Command;
using Todo.Models;
using Todo.Services;

namespace Todo.Data.Handlers
{
    public class CreateTodoHandler : IRequestHandler<CreateTodoCommand, TodoItem>
    {
        private readonly ITaskRepository _taskRepository;

        public CreateTodoHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<TodoItem> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            TodoItem item = new TodoItem
            {
                Title = request.Title,
                Description = request.Description,
                Completed = request.Completed,
                DueDate = request.DueDate,
                Created = request.Created
            };

            return await _taskRepository.AddTaskAsync(item);
        }
    }
}
