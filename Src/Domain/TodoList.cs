using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TodoList
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public IList<TodoItem> Items { get; set; }

    }
}
