// See https://aka.ms/new-console-template for more information
using Domain;
using Infrasture.Repository;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");



DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();

optionsBuilder.UseSqlServer("Server=LAPTOP-B7PT29QB\\SQLEXPRESS;Database=TodoApp;Trusted_Connection=True;MultipleActiveResultSets=true");

TodoDbContext todoDbContext = new TodoDbContext(optionsBuilder.Options);


var myList = new TodoList();
myList.Title = "House list";

myList.Items = new List<TodoItem>();

myList.Items.Add(new TodoItem() { Task = "clean windows" });

todoDbContext.TodoLists.Add(myList);

//var myItems = new TodoItem();
//myItems.Task = "test";

//todoDbContext.TodoItems.Add(myItems);


todoDbContext.SaveChanges();