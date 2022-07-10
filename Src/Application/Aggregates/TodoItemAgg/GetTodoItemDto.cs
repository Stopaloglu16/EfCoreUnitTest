using Application.Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Aggregates.TodoItemAgg
{
    public class GetTodoItemDto: IMapFrom<TodoItem>
    {
        public Guid Id { get; set; }
        public string Task { get; set; }


        public Guid TodoListId { get; set; }

    }
}
