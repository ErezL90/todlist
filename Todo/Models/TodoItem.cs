using System.ComponentModel.DataAnnotations;

namespace Todo.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Title { get; set; }
        [StringLength(250)]
        public string? Description { get; set; }
        [Required]
        public bool Completed { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
