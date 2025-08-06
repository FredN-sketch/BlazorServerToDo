using BlazorServerToDo.Models;

namespace BlazorServerToDo.Services
{
    public interface IToDoService
    {
        Task DeleteIntake(int id);
        Task<List<ToDoItem>> GetToDoItems();
        Task SaveIntake(ToDoItem item);
    }
}