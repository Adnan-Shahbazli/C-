using Microsoft.Data.SqlClient;

const string connectionString = "Server=localhost;Database=MyDataBase;TrustServerCertificate=True;";

var connection = new SqlConnection(connectionString);

connection.Open();

var command = new SqlCommand("select count(*) from Students", connection);

var result = command.ExecuteScalar();

System.Console.WriteLine(result);