using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace login.services
{
    internal class LoginService
    {
        public bool IsAuthenticated(string username, string password)
        {

            string connectionString = "Data Source=LAPTOP-7SKAH6B6\\SQLEXPRESS;Initial Catalog=universidad;Integrated Security=True";
            string query = $"SELECT * FROM users WHERE lower(username) = lower('{username}')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string passwordDb = reader["password"].ToString();

                        if (password == passwordDb)
                        {
                            return true;
                        }
                    }
                }

                reader.Close();
            }
            return false;
        }
    }
}
