// See https://aka.ms/new-console-template for more information
using Domain;
using Infrasture.Repository;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");



DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();

optionsBuilder.UseSqlServer("Server=LAPTOP-B7PT29QB\\SQLEXPRESS;Database=TodoApp;Trusted_Connection=True;MultipleActiveResultSets=true");


TodoDbContext todoDbContext = new TodoDbContext(optionsBuilder.Options);


var myList = new TodoList();
myList.Title = "test list";

todoDbContext.TodoLists.Add(myList);

//var myItems = new TodoItem();
//myItems.Task = "test";

//todoDbContext.TodoItems.Add(myItems);


todoDbContext.SaveChanges();