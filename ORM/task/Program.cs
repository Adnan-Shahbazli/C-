using task.Data;

var dbContext = new MyDbContext();

var car = dbContext.Cars.First(Car => Car.Name == "Test");

System.Console.WriteLine(car);