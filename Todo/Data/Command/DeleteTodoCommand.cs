using MediatR;

namespace Todo.Data.Command
{
    public class DeleteTodoCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
