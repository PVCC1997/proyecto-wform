using login.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.services
{
    internal class CarreraService
    {
        public List<Carrera> GetCarreras() {
            string connectionString = "Data Source=LAPTOP-7SKAH6B6\\SQLEXPRESS;Initial Catalog=universidad;Integrated Security=True";
            string query = $"SELECT * FROM carrera";

            List<Carrera> list = new List<Carrera>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Carrera carrera = new Carrera();
                        carrera.cod_carrera = reader["cod_carrera"].ToString();
                        carrera.nomb_carrera = reader["nomb_carrera"].ToString();
                        carrera.cod_depto = reader["cod_depto"].ToString();
                        list.Add(carrera);
                    }
                }

                reader.Close();
            }
            return list;
        }
    }
}
