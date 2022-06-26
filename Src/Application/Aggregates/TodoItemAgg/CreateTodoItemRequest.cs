using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Aggregates.TodoItemAgg
{
    public class CreateTodoItemRequest
    {
        public CreateTodoItemRequest( string task)
        {
            Id = new Guid();
            Task = task;
        }

        public Guid Id { get; private set; }
        public string Task { get; set; }

    }
}
