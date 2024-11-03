using BITMINDS.modelos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BITMINDS.repositorios
{
    public class EjercicioRepositorio : RepositorioBase
    {
        public void Insertar(Ejercicio ejercicio)
        {
            string query = "INSERT INTO ejercicios(nombre, descripcion, grupomuscular, tipo, idrutina) " +
                "VALUES (@nombre, @descripcion, @grupomuscular, @tipo, @idrutina)";

            using (var connection = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nombre", ejercicio.Nombre);
                command.Parameters.AddWithValue("@descripcion", ejercicio.Descripcion);
                command.Parameters.AddWithValue("@grupomuscular", ejercicio.GrupoMuscular);
                command.Parameters.AddWithValue("@tipo", ejercicio.Tipo);
                command.Parameters.AddWithValue("@idrutina", ejercicio.Rutina);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<EjercicioAsignado> ObtenerEjerciciosAsignados(string documento, string tipo)
        {
            string query = "SELECT e.*, ad.repeticiones, ad.realizado_d FROM ejercicios e " +
                "INNER JOIN asigna_d ad ON e.id_ejer = ad.id_ejercicio " +
                "INNER JOIN cliente c ON c.num_doc = ad.num_doc AND c.tipo_doc = ad.tipo_doc " +
                "WHERE c.num_doc = @documento AND c.tipo_doc = @tipo_doc";

            var ejercicios = new List<EjercicioAsignado>();
            using (var conn = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@documento", documento);
                command.Parameters.AddWithValue("@tipo_doc", tipo);

                conn.Open();
                using (var reader = command.ExecuteReader()) 
                {
                    while (reader.Read())
                    {
                        var ejercicio = new EjercicioAsignado()
                        {
                            Id = reader.GetInt32("id_ejer"),
                            Nombre = reader.GetString("nombre"),
                            Descripcion = reader.GetString("descripcion"),
                            GrupoMuscular = reader.GetString("grupomuscular"),
                            Tipo = reader.GetString("tipo"),
                            Rutina = reader.GetInt32("idrutina"),
                            Repeticiones = reader.GetInt32("repeticiones"),
                            Realizado = !reader.IsDBNull(reader.GetOrdinal("realizado_d")) ?
                                reader.GetDateTime("realizado_d").ToString("dd/MM/yyyy") : string.Empty
                        };

                        ejercicios.Add(ejercicio);
                    }
                }
            }

            return ejercicios;
        }
        public List<Ejercicio> ObtenerTodosEjercicios()
        {
            string query = "SELECT * FROM ejercicios";

            var ejercicios = new List<Ejercicio>();
            using (var connection = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ejercicio = new Ejercicio()
                        {
                            Id = reader.GetInt32("id_ejer"),
                            Nombre = reader.GetString("nombre"),
                            Descripcion = reader.GetString("descripcion"),
                            GrupoMuscular = reader.GetString("grupomuscular"),
                            Tipo = reader.GetString("tipo"),
                        };

                        ejercicios.Add(ejercicio);
                    }
                }
            }

            return ejercicios;
        }

        public void GuardarEjercicioAsignadoCompletado(EjercicioAsignado ejercicio, string num_doc, string tipo_doc)
        {
            string query = "UPDATE asigna_d SET realizado_d = @realizado" +
                " WHERE num_doc = @num_doc AND tipo_doc = @tipo_doc AND id_ejercicio = @id_ejercicio";

            using (var connection = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@realizado", ejercicio.Realizado);
                command.Parameters.AddWithValue("@num_doc", num_doc);
                command.Parameters.AddWithValue("@tipo_doc", tipo_doc);
                command.Parameters.AddWithValue("@id_ejercicio", ejercicio.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void Eliminar(int id)
        {
            string query = "DELETE FROM ejercicios WHERE id_ejer = @id_ejer";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_ejer", id);

                connection.Open();
                command.ExecuteNonQuery();  
            }

        }
    }
}
