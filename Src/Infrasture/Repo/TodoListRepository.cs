using Domain;
using Infrasture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Infrasture.Repo
{
    public class TodoListRepository : EfCoreRepository<TodoList>, ITodoListRepository
    {

        private readonly TodoDbContext _dbContext;

        public TodoListRepository(TodoDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<TodoList>> GetAllWithItemsAsync()
        {
            //await Task.Delay(100);
            return await GetAll().Include(tt => tt.Items).ToListAsync();
        }


        


    }
}
