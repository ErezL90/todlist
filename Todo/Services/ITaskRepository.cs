using Todo.Models;

namespace Todo.Services
{
    public interface ITaskRepository
    {
        public Task<List<TodoItem>> GetTaskListAsync();
        public Task<TodoItem> GetTaskByIdAsync(int id);
        public Task<TodoItem> AddTaskAsync(TodoItem todoItem);
        public Task<int> UpdateTaskAsync(TodoItem todoItem);
        public Task<int> DeleteTaskAsync(int Id);
    }
}
