using Domain;
using Infrasture.Repository;
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
