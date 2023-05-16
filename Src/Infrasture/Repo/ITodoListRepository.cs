using Application.Common;
using Domain;

namespace Infrasture.Repo
{
    public interface ITodoListRepository : IRepository<TodoList>
    {

        public Task<List<TodoList>> GetAllWithItemsAsync();
    }
}
