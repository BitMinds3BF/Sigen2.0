using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITMINDS.repositorios
{
    public class RutinaRepositorio : RepositorioBase
    {
        public List<int> ObtenerRutinas()
        {
            string query = "SELECT * FROM rutina";

            var rutinas = new List<int>();
            using (var connection = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rutinas.Add(reader.GetInt32(0)); // 0 es la unica columna de la tabla rutina
                    }
                }
            }

            return rutinas;
        }
    }
}
