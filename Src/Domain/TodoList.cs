namespace Domain
{
    public class TodoList
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<TodoItem> Items { get; set; } = new List<TodoItem>();

    }
}
