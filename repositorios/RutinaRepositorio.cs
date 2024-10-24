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
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                var cmd = new MySqlCommand(query, conn);
                conn.Open();
                var reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    rutinas.Add(reader.GetInt32(0));
                }
            }

            return rutinas;
        }
    }
}
