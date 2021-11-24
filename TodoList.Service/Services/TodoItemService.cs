using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodoList.Data.Interfaces;
using TodoList.Data.Repository;
using TodoList.Model;
using TodoList.Service.Interfaces;

namespace TodoList.Service.Services
{
    public class TodoItemService : ITodoItemService
    {

        public readonly ITodoItemRepository _todoItemRepository;

        public TodoItemService(ITodoItemRepository todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }
        public async Task<bool> AddTodoItem(TodoItem todoItem,string currentuser)
        {
           return await _todoItemRepository.AddTodoItem(todoItem, currentuser);
        }

        public async Task<bool> DeleteTodoItem(Guid todoitem, string currentuser)
        {
            return await _todoItemRepository.DeleteTodoItem(todoitem, currentuser);
        }

        public List<TodoItem> GetTodoItems(string currentuser)
        {
            return _todoItemRepository.GetTodoItems(currentuser);
        }

        public async Task<bool> UpdateTodoItem(TodoItem todoItem, string currentuser)
        {
            return await _todoItemRepository.UpdateTodoItem(todoItem,currentuser);
        }
    }
}
