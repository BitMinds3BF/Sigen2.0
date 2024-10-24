using BITMINDS.modelos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITMINDS.repositorios
{
    public class DeporteRepositorio : RepositorioBase
    {
        public void Insertar(Deporte deporte)
        {
            string query = "INSERT INTO deporte(deporte) VALUES(@deporte)";
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@deporte", deporte.Nombre);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public List<Deporte> ObtenerDeportes() 
        {
            string query = $"SELECT * FROM deporte";

            List<Deporte> deportes = new List<Deporte>();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                var cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    deportes.Add
                    (
                        new Deporte()
                        {
                            Id = Convert.ToInt32(reader["id_deporte"]),
                            Nombre = reader["deporte"].ToString(),

                        }
                    );
                }   
            }
            return deportes;
        }
    }
}
