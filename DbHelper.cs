using MySql.Data.MySqlClient;
using System.Configuration;

namespace Starbuko
{
    public static class DbHelper
    {
        private static readonly string connectionString =
            ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}