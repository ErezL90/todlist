using Microsoft.EntityFrameworkCore;
using Todo.Data;
using Todo.Models;

namespace Todo.Services
{
    public class TaskRepository : ITaskRepository
    {

        private readonly TodoDbContext _context;
        public TaskRepository(TodoDbContext context)
        {
            _context = context;
        }

        public async Task<TodoItem> AddTaskAsync(TodoItem todoItem)
        {
            var result = _context.Todoitems.Add(todoItem);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteTaskAsync(int id)
        {
            var filteredData = _context.Todoitems.Where(x => x.Id == id).FirstOrDefault();
            _context.Todoitems.Remove(filteredData);
            return await _context.SaveChangesAsync();
        }

        public async Task<TodoItem> GetTaskByIdAsync(int id)
        {
            var filteredData = await _context.Todoitems.Where(x => x.Id == id).FirstOrDefaultAsync();
            return filteredData;
        }

        public async Task<List<TodoItem>> GetTaskListAsync()
        {
            var taskList = await _context.Todoitems.ToListAsync();
            return taskList;
        }

        public async Task<int> UpdateTaskAsync(TodoItem todoItem)
        {
            _context.Todoitems.Update(todoItem);
            return await _context.SaveChangesAsync();
        }
    }
}
