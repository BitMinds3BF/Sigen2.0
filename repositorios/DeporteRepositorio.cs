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
            using (var connection = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@deporte", deporte.Nombre);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public List<Deporte> ObtenerDeportes() 
        {
            string query = "SELECT * FROM deporte";

            var deportes = new List<Deporte>();
            using (var connection = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var deporte = new Deporte()
                        {
                            Id = reader.GetInt32("id_deporte"),
                            Nombre = reader.GetString("deporte"),
                        };

                        deportes.Add(deporte);
                    }
                }
            }
            return deportes;
        }
    }
}
