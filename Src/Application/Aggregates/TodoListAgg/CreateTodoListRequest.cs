using Domain;

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
