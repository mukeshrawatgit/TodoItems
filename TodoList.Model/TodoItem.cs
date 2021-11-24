using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TodoList.Model
{
   
    public class TodoItem
    {
        public TodoItem()
        {
            
            ModifedDate = DateTime.Now;
        }
        [Required,  Key]
        public Guid Id { get; set; }

        public string UserId { get; set; }

        public string Description { get; set; }

        public DateTime ModifedDate { get; }

        public bool IsSelected { get; set; }
    }
}
