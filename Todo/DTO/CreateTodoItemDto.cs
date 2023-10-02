namespace Todo.DTO
{
    public class CreateTodoItemDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool Completed { get; set; }
        public DateTime DueDate { get; set; }

    }
}
