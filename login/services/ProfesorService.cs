using login.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.services
{
    internal class ProfesorService
    {
        public List<Profesor> GetProfesors()
        {
            string connectionString = "Data Source=LAPTOP-7SKAH6B6\\SQLEXPRESS;Initial Catalog=universidad;Integrated Security=True";
            string query = $"SELECT * FROM profesor";

            List<Profesor> list = new List<Profesor>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Profesor profesor = new Profesor();
                        profesor.cod_prof = reader["cod_prof"].ToString();
                        profesor.nom_prof = reader["nomb_prof"].ToString();
                        profesor.ape_prof = reader["ape_prof"].ToString();
                        profesor.cod_depto = reader["cod_depto"].ToString();
                        list.Add(profesor);
                    }
                }

                reader.Close();
            }
            return list;
        }
    }
}
