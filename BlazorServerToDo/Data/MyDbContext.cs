using BlazorServerToDo.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerToDo.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {        
        }
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
