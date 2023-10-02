using MediatR;

namespace Todo.Data.Command
{
    public class UpdateTodoCommand : IRequest<int>
    {
        public UpdateTodoCommand(int id, string? title, string? description, bool completed, DateTime dueDate, DateTime updated)
        {
            Id = id;
            Title = title;
            Description = description;
            Completed = completed;
            DueDate = dueDate;
            Updated = updated;
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool Completed { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime Updated { get; set; }
    }
}
