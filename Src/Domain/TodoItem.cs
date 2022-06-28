using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Task { get; set; }


        public Guid TodoListId { get; set; }
        public TodoList TodoList { get; set; }

    }

}
