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
