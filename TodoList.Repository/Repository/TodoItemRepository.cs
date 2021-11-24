using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Data.Contexts;
using TodoList.Data.Interfaces;
using TodoList.Model;

namespace TodoList.Data.Repository
{
    public class TodoItemRepository : ITodoItemRepository
    {
        public readonly TodoContext _todoContext;

        public TodoItemRepository(TodoContext todoContext)
        {
            _todoContext = todoContext;
        }
        public async Task<bool> AddTodoItem(TodoItem todoItem, string currentuser)
        {
            todoItem.Id = Guid.NewGuid();
            todoItem.UserId = currentuser;
            _todoContext.Todos.Add(todoItem);
            var isSaved = await _todoContext.SaveChangesAsync();
            return isSaved > 0;
        }

        public async Task<bool> DeleteTodoItem(Guid id, string currentUser)
        {
            var todo = _todoContext.Todos.Where(x => x.Id == id && x.UserId == currentUser).FirstOrDefault();
            _todoContext.Todos.Remove(todo);
            var isdeleted =await _todoContext.SaveChangesAsync();
            return isdeleted > 0;
        }

        public List<TodoItem> GetTodoItems(string currentuser)
        {
            return _todoContext.Todos.Where(x => x.UserId == currentuser).ToList();
        }

      

        public async Task<bool> UpdateTodoItem(TodoItem editedtodoItem, string currentuser)
        {
            var todo = _todoContext.Todos
                      .Where(x => x.Id == editedtodoItem.Id && x.UserId == currentuser)
                      .FirstOrDefault();

            if (todo == null) return false;

            todo.IsSelected = editedtodoItem.IsSelected;
            var isupdated =await _todoContext.SaveChangesAsync();
            return isupdated == 1;

        }

       
    }
}
