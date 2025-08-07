using BlazorServerToDo.Models;

namespace BlazorServerToDo.Services
{
    public interface IToDoService
    {
        Task DeleteItem(int id);
        Task<List<ToDoItem>> GetToDoItems();
        Task SaveItem(ToDoItem item);
    }
}