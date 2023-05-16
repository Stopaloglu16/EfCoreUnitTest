using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrasture.Repository
{
    public class TodoDbContext : DbContext
    {

        public TodoDbContext(DbContextOptions options)
           : base(options)
        {
        }



        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }

    }
}
