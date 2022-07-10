using Application.Aggregates.TodoItemAgg;
using Application.Aggregates.TodoListAgg;
using Domain;
using Infrasture.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {

        private readonly ITodoListRepository _todoListRepository;

        public TodoListController(ITodoListRepository todoListRepository)
        { 
            _todoListRepository = todoListRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<GetTodoListDto>> Get()
        {

            List<GetTodoListDto> getTodoListDtos = new List<GetTodoListDto>();

            var mylist = await _todoListRepository.GetAllWithItemsAsync();


            for (int i = 0; i < mylist.Count; i++)
            {

                getTodoListDtos.Add(new GetTodoListDto()
                {
                    Id = mylist[i].Id,
                    Title = mylist[i].Title
                });

                var myLl = mylist[i].Items.ToList();

                for (int aa = 0; aa < myLl.Count; aa++)
                {
                    getTodoListDtos[i].Items.Add(  new GetTodoItemDto() { Id = myLl[aa].Id, Task = myLl[aa].Task } );
                }

            }

            return getTodoListDtos;

        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(GetTodoListDto todoListDto)
        {
            try
            {

                var myRtn = await _todoListRepository.AddAsync(new TodoList() { Title = todoListDto.Title });

                return Ok(myRtn.Id);

            }
            catch (Exception ex)
            {
                await Task.Delay(500);
                return BadRequest(ex.Message);
            }
        }


    }
}
