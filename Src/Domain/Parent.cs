namespace Domain
{
    public class Parent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Child> Children { get; set; }

    }
}
