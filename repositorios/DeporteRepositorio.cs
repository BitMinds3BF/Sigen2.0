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
            string query = "INSERT INTO deporte(nombre) VALUES(@nombre)";
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", deporte.Nombre);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
