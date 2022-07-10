using Application.Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrasture.Repo
{
    public interface ITodoListRepository: IRepository<TodoList>
    {

        public Task<List<TodoList>> GetAllWithItemsAsync();
    }
}
