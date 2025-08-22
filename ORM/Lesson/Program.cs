using Microsoft.Data.SqlClient;
using Dapper;
using Lesson.Models;

const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MyDatabase;Trusted_Connection=True;TrustServerCertificate=True;";

using var connection = new SqlConnection(connectionString);
connection.Open();
 
System.Console.Write("Enter the id from:");
 
string idFromString = Console.ReadLine();

System.Console.Write("Enter the id to:");

string idToString = Console.ReadLine();

int idFrom = Convert.ToInt32(idFromString);

int idTo = Convert.ToInt32(idToString);

var result = connection.Query<Product>(@"select * from Products
                                where id between @idFrom and @idTo",
                                param: new {
                                    idFrom = idFrom,
                                    idTo = idTo
                                    });

foreach (var item in result)
{
    System.Console.WriteLine(item);
}