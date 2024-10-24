using BITMINDS.modelos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BITMINDS.repositorios.Usuarios
{
    public class AvanzadoRepositorio
    {
    //    public List<Cliente> ObtenerClientes()
    //    {
    //        string query = "SELECT u.*, (SELECT GROUP_CONCAT(t.numero SEPARATOR ',') FROM telefonos t " +
    //            " WHERE t.documento = u.documento) AS telefonos, c.evolucion, c.grado_cumplimiento, c.tipo " +
    //            $" FROM usuarios u INNER JOIN clientes c ON c.documento=u.documento WHERE u.rol = 1";
         
    //        List<Cliente> clientes = new List<Cliente>();

    //        using (MySqlConnection connection = new MySqlConnection(connectionBuilder.ConnectionString))
    //        using (MySqlCommand command = new MySqlCommand(query, connection)) 
            
    //        {
    //            connection.Open();
    //            using (MySqlDataReader reader = command.ExecuteReader()) 
    //            {
    //                while (reader.Read()) 
    //                {
    //                    clientes.Add(
    //                        new Cliente(
    //                            reader["documento"].ToString(),
    //                            (int)reader["tipo_doc"],
    //                            reader["nombre"].ToString(),
    //                            reader["apellido"].ToString(),
    //                            reader["direccion"].ToString(),
    //                            reader["telefonos"].ToString(),
    //                            (int)reader["rol"],
    //                            (int)reader["tipo"],
    //                            (int)reader["evolucion"],
    //                            (int)reader["grado_cumplimiento"]
    //                        )
    //                    );
    //                }
    //            }
    //        }
    //        return clientes;
    //    }
    }
}
