using login.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.services
{
    internal class EstudianteService
    {
        public List<Estudiante> GetEstudiantes()
        {
            string connectionString = "Data Source=LAPTOP-7SKAH6B6\\SQLEXPRESS;Initial Catalog=universidad;Integrated Security=True";
            string query = $"SELECT * FROM estudiante";

            List<Estudiante> list = new List<Estudiante>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Estudiante estudiante = new Estudiante();
                        estudiante.cod_estudiante = reader["cod_estudiante"].ToString();
                        estudiante.nomb_estudiante = reader["nomb_estudiante"].ToString();
                        estudiante.ape_estudiante = reader["ape_estudiante"].ToString();
                        estudiante.cod_carrera = reader["cod_carrera"].ToString();
                        list.Add(estudiante);
                    }
                }

                reader.Close();
            }
            return list;
        }
    }
}
