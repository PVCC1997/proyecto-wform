using login.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.services
{
    internal class DepartamentoService
    {

        public List<Departamento> GetDepartamentos()
        {
            string connectionString = "Data Source=LAPTOP-7SKAH6B6\\SQLEXPRESS;Initial Catalog=universidad;Integrated Security=True";
            string query = $"SELECT * FROM departamento";

            List<Departamento> list = new List<Departamento>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Departamento departamento = new Departamento();
                        departamento.cod_depto = reader["cod_depto"].ToString();
                        departamento.nomb_depto = reader["nombre_depto"].ToString();
                        list.Add(departamento);
                    }
                }

                reader.Close();
            }
            return list;
        }
    }
}
