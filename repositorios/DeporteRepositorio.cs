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

        public Deporte ObtenerDeporte(int id)
        {
            string query = "SELECT * FROM deporte WHERE id_deporte = @id_deporte";
            using (var connection = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id_deporte", id);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    reader.Read();

                    return new Deporte()
                    {
                        Id = reader.GetInt32("id_deporte"),
                        Nombre = reader.GetString("deporte")
                    };
                }
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

        public void Actualizar(Deporte deporte)
        {
            string query = "UPDATE deporte SET deporte = @deporte" +
                " WHERE id_deporte = @id_deporte";
            using (var conn = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@deporte", deporte.Nombre);
                command.Parameters.AddWithValue("@id_deporte", deporte.Id);
                conn.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            string query = $"DELETE FROM Deporte WHERE id_deporte = @id_deporte";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_deporte", id);

                connection.Open();
                command.ExecuteNonQuery ();
            }
        }
    }
}
