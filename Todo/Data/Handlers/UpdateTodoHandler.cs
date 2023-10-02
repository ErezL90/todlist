using MediatR;
using Todo.Data.Command;
using Todo.Models;
using Todo.Services;

namespace Todo.Data.Handlers
{
    public class UpdateTodoHandler : IRequestHandler<UpdateTodoCommand, int>
    {
        private readonly ITaskRepository _taskRepository;
        public UpdateTodoHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<int> Handle(UpdateTodoCommand request, CancellationToken cancellationToken)
        {
            var todoitem = await _taskRepository.GetTaskByIdAsync(request.Id);

            if (todoitem == null) return default;

            todoitem.Title = request.Title;
            todoitem.Description = request.Description;
            todoitem.Completed = request.Completed;
            todoitem.DueDate= request.DueDate;
            todoitem.Updated = request.Updated;

            return await _taskRepository.UpdateTaskAsync(todoitem);

        }
    }
}
