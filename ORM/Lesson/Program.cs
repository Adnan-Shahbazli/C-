using Microsoft.Data.SqlClient;
using Dapper;

const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MyDatabase;Trusted_Connection=True;TrustServerCertificate=True;";

using var connection = new SqlConnection(connectionString);
connection.Open();
 
System.Console.Write("Enter price:");
 
string priceString = Console.ReadLine();

double price = Convert.ToDouble(priceString);



var result = connection.Query($"select * from Products where Price > {price}");

foreach (var item in result)
{
    System.Console.WriteLine(item);
}

// var command = connection.CreateCommand();
 
// System.Console.WriteLine("Enter price:");
 
// string priceString = Console.ReadLine();
 
// double price = Convert.ToDouble(priceString);
 
// command.CommandText = "select * from Products where Price > @price";
 
// command.Parameters.Add(new SqlParameter("price", price));
 
// var result = command.ExecuteReader();
 
// while(result.Read())
// {
//     System.Console.WriteLine($"Id = {result.GetInt32(0)}, Name = {result.GetString(1)}, Price = {result.GetDecimal(2)}");
// }
 
// Console.WriteLine(result);