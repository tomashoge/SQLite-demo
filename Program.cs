using SQLite_demo.Services;
using SQLiteDemo.Models;

var dbService = new PersonService();

Console.WriteLine("---Init db content---");
var dbContent = await dbService.GetAsync();
dbContent.ForEach(x => Console.WriteLine(x.FullName));

Console.WriteLine("---Add records---");
await dbService.AddAsync(new PersonModel() { FirstName = "David", LastName = "Smith" });
await dbService.AddAsync(new PersonModel() { FirstName = "Peter", LastName = "Window" });
dbContent = await dbService.GetAsync();
dbContent.ForEach(x => Console.WriteLine(x.FullName));

Console.WriteLine("---Delete first record---");
await dbService.DeleteAsync(dbContent.First());
dbContent = await dbService.GetAsync();
dbContent.ForEach(x => Console.WriteLine(x.FullName));

Console.WriteLine("---Rename first record---");
var firstPerson = dbContent.First();
firstPerson.FirstName = "Tomas";
await dbService.UpdateAsync(firstPerson);
dbContent = await dbService.GetAsync();
dbContent.ForEach(x => Console.WriteLine(x.FullName));

Console.ReadLine();
