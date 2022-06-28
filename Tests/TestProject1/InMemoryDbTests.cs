using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Application;
using Application.Aggregates.TodoListAgg;
using Application.Aggregates.TodoItemAgg;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace TestProject1
{
    public class InMemoryDbTests : TestBase
    {

        // Added new lines to have same line numbers as
        // the Sqlite unit test file.
        public InMemoryDbTests() { }


        [Test]
        public async Task ShouldBeAbleToAddAndGetEntity()
        {
            // Prepare
            using var context = await GetDbContext();

            var mytodoItems = new List<TodoItem>();

            var mytodoItem = new CreateTodoItemRequest("Banana");

            var myTodoList = new CreateTodoListRequest( "Food", null );

            
            context.TodoLists.Add(new TodoList
            {
                Id = myTodoList.Id,
                Title = myTodoList.Title,
                 Items  = new List<TodoItem>() { new TodoItem() { Id = mytodoItem.Id, Task = mytodoItem.Task }  }

            });
            await context.SaveChangesAsync();

            // Execute
            var data = await context.TodoItems.ToListAsync();

            Assert.AreEqual(1, data.Count);

            // Assert
            //Assert.Single(data);
            //Assert.Contains(data, );
            //Assert.Contains(data, d => d.Name == "Parent name");
            //Assert.Contains(data, d => d.Child.Name == "Child name");
        }


    }
}
