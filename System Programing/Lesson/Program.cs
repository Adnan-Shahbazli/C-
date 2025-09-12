using Dapper;
using Lesson.Models;
using Microsoft.Data.SqlClient;

string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MyDataBase;TrustServerCertificate=True;";

List<Human> people = new List<Human>
{
    new Human { firstName = "Иван", lastName = "Иванов", birthday = new DateTime(2000, 5, 12) },
    new Human { firstName = "Петр", lastName = "Петров", birthday = new DateTime(1998, 11, 3) },
    new Human { firstName = "Сергей", lastName = "Сергеев", birthday = new DateTime(2001, 2, 20) },
    new Human { firstName = "Алексей", lastName = "Алексеев", birthday = new DateTime(1995, 8, 15) },
    new Human { firstName = "Дмитрий", lastName = "Дмитриев", birthday = new DateTime(1999, 7, 7) },
    new Human { firstName = "Николай", lastName = "Николаев", birthday = new DateTime(2002, 3, 25) },
    new Human { firstName = "Андрей", lastName = "Андреев", birthday = new DateTime(1997, 12, 1) },
    new Human { firstName = "Владимир", lastName = "Владимиров", birthday = new DateTime(1996, 9, 18) },
    new Human { firstName = "Егор", lastName = "Егоров", birthday = new DateTime(2003, 6, 30) },
    new Human { firstName = "Михаил", lastName = "Михайлов", birthday = new DateTime(2000, 4, 10) }
};

Parallel.ForEach(people, (human) =>
{
    using var connection = new SqlConnection(connectionString);
    connection.Open();
    connection.Execute("insert into People (FirstName, LastName, Birthday) values (@firstName, @lastName, @birthday)",param: new { firstName = human.firstName, lastName = human.lastName, birthday = human.birthday });
});
