using Microsoft.Data.SqlClient;
using Dapper;

namespace Who_wants_to_become_a_millionaire.Models
{
    public class Game
    {
        private const string connectionString = "Server=(localdb)\\MSSQLLocalDB  ;Database=MyDatabase;Trusted_Connection=True;TrustServerCertificate=True;";
        public SqlConnection connect = new SqlConnection(connectionString);
        
    }
}