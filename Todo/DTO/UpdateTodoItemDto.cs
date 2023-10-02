using System.ComponentModel.DataAnnotations;

namespace Todo.DTO
{
    public class UpdateTodoItemDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool Completed { get; set; }
        public DateTime DueDate { get; set; }
    }
}
