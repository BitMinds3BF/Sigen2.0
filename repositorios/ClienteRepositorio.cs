using BITMINDS.modelos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BITMINDS.repositorios.cliente
{
     public class ClienteRepositorio : RepositorioBase
     {
        public void Insertar(Cliente cliente)
        {
            Console.WriteLine(ConnectionString);
            string query = "INSERT INTO cliente (num_doc, tipo_doc, email, nombre, apellido, departamento, calle," +
                " numero) VALUES (@num_doc, @tipo_doc, @email, @nombre, @apellido, @departamento, @calle, @numero)";

            using (var connection = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@num_doc", cliente.NumDoc);
                command.Parameters.AddWithValue("@tipo_doc", cliente.TipoDoc);
                command.Parameters.AddWithValue("@email", cliente.Email);
                command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@departamento", cliente.Departamento);
                command.Parameters.AddWithValue("@calle", cliente.Calle);
                command.Parameters.AddWithValue("@numero", cliente.Numero);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public int InsertarUsuario(Usuario usuario, string contraseña)
        {
            string query = "INSERT INTO usuario (contraseña, rol) VALUES (@contraseña, @rol)";

            using (var connection = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@contraseña", contraseña);
                command.Parameters.AddWithValue("@rol", usuario.Rol);

                connection.Open();
                command.ExecuteNonQuery();
                return (int)command.LastInsertedId;
            }
        }

        public void InsertarLoguea(string num_doc, string tipo_doc, int id_usuario)
        {
            string query = "INSERT INTO loguea (num_doc, tipo_doc, id_usuario) VALUES" +
                "(@num_doc, @tipo_doc, @id_usuario)";

            using (var connection = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@num_doc", num_doc);
                command.Parameters.AddWithValue("@tipo_doc", tipo_doc);
                command.Parameters.AddWithValue("@id_usuario", id_usuario);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void InsertarDeportista(string num_doc, string tipo_doc)
        {
            string query = "INSERT INTO deportista(num_doc, tipo_doc) VALUES" +
                "(@num_doc, @tipo_doc)";

            using (var connection = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@num_doc", num_doc);
                command.Parameters.AddWithValue("@tipo_doc", tipo_doc);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void InsertarPaciente(string num_doc, string tipo_doc)
        {
            string query = "INSERT INTO paciente(num_doc, tipo_doc) VALUES " +
                "(@num_doc, @tipo_doc)";

            using (var connection = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@num_doc", num_doc);
                command.Parameters.AddWithValue("@tipo_doc", tipo_doc);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Cliente ObtenerCliente(string documento, string tipo, bool contraseña = false)
        {
            string query = "SELECT c.*, u.rol, u.id_usuario, u.contraseña FROM cliente c " +
                "INNER JOIN loguea l ON l.num_doc = c.num_doc AND l.tipo_doc = c.tipo_doc " +
                "INNER JOIN usuario u ON u.id_usuario = l.id_usuario " +
                "WHERE c.num_doc = @documento AND c.tipo_doc = @tipo";

            using (var connection = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@documento", documento);
                command.Parameters.AddWithValue("@tipo", tipo);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    reader.Read();

                    if (!reader.HasRows)
                    {
                        return null;
                    }

                    return new Cliente(contraseña ? reader.GetString("contraseña") : null)
                    {
                        NumDoc = reader.GetString("num_doc"),
                        TipoDoc = reader.GetString("tipo_doc"),
                        Email = reader.GetString("email"),
                        Nombre = reader.GetString("nombre"),
                        Apellido = reader.GetString("apellido"),
                        Departamento = reader.GetString("departamento"),
                        Calle = reader.GetString("calle"),
                        Numero = reader.GetString("numero"),
                        Rol = reader.GetString("rol"),
                        Id = reader.GetInt32("id_usuario")
                    };
                }
            }
        }

        public List<Cliente> ObtenerTodos()
        {
            var clientes = new List<Cliente>();

            string query = "SELECT * FROM cliente c INNER JOIN loguea l" +
                " ON c.num_doc = l.num_doc AND c.tipo_doc = l.tipo_doc" +
                " INNER JOIN usuario u" +
                " ON u.id_usuario = l.id_usuario WHERE u.rol = 'cliente'";

            using (var connection = new MySqlConnection(ConnectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cliente = new Cliente
                        {
                            NumDoc = reader.GetString("num_doc"),
                            TipoDoc = reader.GetString("tipo_doc"),
                            Email = reader.GetString("email"),
                            Nombre = reader.GetString("nombre"),
                            Apellido = reader.GetString("apellido"),
                            Departamento = reader.GetString("departamento"),
                            Calle = reader.GetString("calle"),
                            Numero = reader.GetString("numero"),

                        };

                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;
        }
        public void Eliminar(int id)
        {
            string query = "DELETE FROM Usuario WHERE id_usuario = @id_usuario";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_usuario", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    } 

}
    

