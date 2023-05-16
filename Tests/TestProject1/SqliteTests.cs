using Application.Aggregates.TodoItemAgg;
using Application.Aggregates.TodoListAgg;
using Domain;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestProject1
{
    public class SqliteTests : TestBase
    {

        public SqliteTests()
        {
            UseSqlite();
        }

        [Test]
        public async Task ShouldBeAbleToAddAndGetEntity()
        {
            // Prepare
            using var context = await GetDbContext();

            var mytodoItems = new List<TodoItem>();
            var mytodoItem = new CreateTodoItemRequest("Banana");
            var myTodoList = new CreateTodoListRequest("Food", null);

            var myToDo = new TodoList
            {
                Id = myTodoList.Id,
                Title = myTodoList.Title,
                Items = new List<TodoItem>() { new TodoItem() { Id = mytodoItem.Id, Task = mytodoItem.Task },
                                               new TodoItem() { Id = mytodoItem.Id, Task = mytodoItem.Task }}
            };

            context.TodoLists.Add(myToDo);

            await context.SaveChangesAsync();

            // Execute
            var data = await context.TodoLists.ToListAsync();

            // Assert
            Assert.AreEqual(1, data.Count);
            Assert.AreEqual(2, data[0].Items.Count);

        }

    }
}
