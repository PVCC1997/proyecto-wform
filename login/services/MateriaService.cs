using login.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.services
{
    internal class MateriaService
    {
        public List<Materia> GetMaterias()
        {

            string connectionString = "Data Source=LAPTOP-7SKAH6B6\\SQLEXPRESS;Initial Catalog=universidad;Integrated Security=True";
            string query = $"SELECT * FROM materia";

            List<Materia> list = new List<Materia>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Materia materia = new Materia();
                        materia.cod_materia = reader["cod_materia"].ToString();
                        materia.nomb_materia = reader["nomb_materia"].ToString();
                        materia.uv = float.Parse(reader["uv"].ToString());
                        list.Add(materia);
                    }
                }

                reader.Close();
            }
            return list;
        }
    }
}
