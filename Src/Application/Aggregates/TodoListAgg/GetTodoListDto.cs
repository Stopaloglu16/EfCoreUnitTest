using Application.Aggregates.TodoItemAgg;
using Application.Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Aggregates.TodoListAgg
{
    public class GetTodoListDto: IMapFrom<TodoList>
    {

        public Guid Id { get; set; }
        public string Title { get; set; }

        public ICollection<GetTodoItemDto> Items { get; set; } = new List<GetTodoItemDto>();

    }
}
