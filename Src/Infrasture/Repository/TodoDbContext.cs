using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
