using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Aggregates.TodoListAgg
{
    public class CreateTodoListRequest
    {
        public CreateTodoListRequest(string title, IList<TodoItem> items)
        {
            Id = new Guid();
            Title = title;
            Items = items;
        }

        public Guid Id { get; private set; }
        public string Title { get; set; }

        public IList<TodoItem> Items { get; set; }

    }
}
