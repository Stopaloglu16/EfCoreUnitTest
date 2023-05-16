using Application.Common;
using Domain;

namespace Application.Aggregates.TodoItemAgg
{
    public class GetTodoItemDto : IMapFrom<TodoItem>
    {
        public Guid Id { get; set; }
        public string Task { get; set; }


        public Guid TodoListId { get; set; }

    }
}
