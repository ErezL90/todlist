using MediatR;
using Todo.Models;

namespace Todo.Data.Command
{
    public class CreateTodoCommand : IRequest<TodoItem>
    {
        public CreateTodoCommand(string? title, string? description, bool completed, DateTime dueDate, DateTime created)
        {
            Title = title;
            Description = description;
            Completed = completed;
            DueDate = dueDate;
            Created = created;
        }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool Completed { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime Created { get; set; }
    }
}
