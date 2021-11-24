using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodoList.Model;

namespace TodoList.Data.Interfaces
{
    public interface ITodoItemRepository
    {
        List<TodoItem> GetTodoItems(string currentuser);
        Task<bool> AddTodoItem(TodoItem todoItem, string currentuser);
        Task<bool> DeleteTodoItem(Guid todoitem, string currentuser);
        Task<bool> UpdateTodoItem(TodoItem todoItem, string currentuser);
    }
}
