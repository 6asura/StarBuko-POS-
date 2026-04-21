using MySql.Data.MySqlClient;

namespace Starbuko
{
    public class UserRepository
    {
        public User Login(string username, string password)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT id, username, password, full_name, role
                    FROM users
                    WHERE username = @username AND password = @password
                    LIMIT 1";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = reader.GetInt32("id"),
                                Username = reader.GetString("username"),
                                Password = reader.GetString("password"),
                                FullName = reader.GetString("full_name"),
                                Role = reader.GetString("role")
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}