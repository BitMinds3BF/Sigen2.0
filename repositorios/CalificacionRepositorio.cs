using BITMINDS.modelos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITMINDS.repositorios
{
    public class CalificacionRepositorio : RepositorioBase
    {
        public List<Calificacion> ObtenerCalificaciones(string num_doc, string tipo_doc)
        {
            string query = "SELECT c.id_calif AS id, c.item, o.fecha_calif AS fecha, o.puntaje_obtenido FROM calificaciones c" +
                " INNER JOIN obtiene o ON o.id_calif = c.id_calif " +
                " INNER JOIN cliente cli ON cli.num_doc = o.num_doc AND cli.tipo_doc = o.tipo_doc" +
                " WHERE cli.num_doc = @num_doc AND cli.tipo_doc = @tipo_doc";
            var calificaciones = new List<Calificacion>();

            using (var conn = new MySqlConnection(ConnectionString))
            using (var command = new  MySqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@num_doc", num_doc);
                command.Parameters.AddWithValue("@tipo_doc", tipo_doc);

                conn.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var calificacion = new Calificacion()
                        {
                            Id = reader.GetInt32("id"),
                            Item = reader.GetString("item"),
                            Fecha = reader.GetDateTime("fecha").ToString("dd/MM/yyyy"),
                            PuntajeObtenido = reader.GetInt32("puntaje_obtenido")
                        };

                        calificaciones.Add(calificacion);
                    }
                }
            }
            
            return calificaciones;
        }
    }
}
