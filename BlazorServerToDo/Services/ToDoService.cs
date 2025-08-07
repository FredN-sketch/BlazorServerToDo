using BlazorServerToDo.Data;
using BlazorServerToDo.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerToDo.Services
{
    public class ToDoService : IToDoService
    {
        private readonly MyDbContext _db;
        public ToDoService(MyDbContext db)
        {
            _db = db;
        }
        public async Task<List<ToDoItem>> GetToDoItems()
        {
            return await _db.ToDoItems.ToListAsync();
        }
        public async Task SaveItem(ToDoItem item)
        {
            _db.Add(item);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteItem(int id)
        {
            _db.ToDoItems.Remove(_db.ToDoItems.Single(x => x.Id == id));
            await _db.SaveChangesAsync();
        }
    }
}
