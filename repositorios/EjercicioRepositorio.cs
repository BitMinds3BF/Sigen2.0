﻿using BITMINDS.modelos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITMINDS.repositorios
{
    public class EjercicioRepositorio : RepositorioBase
    {
        public void Insertar(Ejercicio ejercicio)
        {
            string query = "INSERT INTO ejercicios(nombre, descripcion, grupomuscular, tipo) " +
                "VALUES (@nombre, @descripcion, @grupomuscular, @tipo)";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", ejercicio.Nombre);
                command.Parameters.AddWithValue("@descripcion", ejercicio.Descripcion);
                command.Parameters.AddWithValue("@grupomuscular", ejercicio.GrupoMuscular);
                command.Parameters.AddWithValue("@tipo", ejercicio.Tipo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Ejercicio> ObtenerEjercicios(string documento, string tipo)
        {
            string query = $"SELECT e.*, ad.repeticiones FROM ejercicios e " +
                $"INNER JOIN asigna_d ad ON e.id_ejer = ad.id_ejer " +
                $"INNER JOIN cliente c ON c.num_doc = ad.num_doc AND c.tipo_doc = ad.tipo_doc " +
                $"WHERE c.num_doc = '{documento}' AND c.tipo_doc = '{tipo}'";

            List<Ejercicio> ejercicios = new List<Ejercicio>();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                var cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ejercicios.Add
                    (
                        new Ejercicio()
                        {
                            Id = Convert.ToInt32(reader["id_ejer"]),
                            Nombre = reader["nombre"].ToString(),
                            Descripcion = reader["descripcion"].ToString(),
                            GrupoMuscular = reader["grupomuscular"].ToString(),
                            Tipo = reader["tipo"].ToString(),

                        }
                    );
                }
            }

            return ejercicios;
        }
        public List<Ejercicio> ObtenerTodosEjercicios()
        {
            string query = $"SELECT * FROM ejercicios";

            List<Ejercicio> ejercicios = new List<Ejercicio>();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                var cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ejercicios.Add
                    (
                        new Ejercicio()
                        {
                            Id = Convert.ToInt32(reader["id_ejer"]),
                            Nombre = reader["nombre"].ToString(),
                            Descripcion = reader["descripcion"].ToString(),
                            GrupoMuscular = reader["grupomuscular"].ToString(),
                            Tipo = reader["tipo"].ToString(),

                        }
                    );
                }
            }

            return ejercicios;
        }
    }
}
