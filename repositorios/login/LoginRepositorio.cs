using BITMINDS.dtos;
using MySqlConnector;

namespace BITMINDS.repositorios.login
{
    public class LoginRepositorio
    {
        private MySqlConnectionStringBuilder connectionBuilder;

        public LoginRepositorio() 
        {
            connectionBuilder = new MySqlConnectionStringBuilder();
            connectionBuilder["Server"] = "localhost";
            connectionBuilder["Database"] = "bitminds";

            connectionBuilder.UserID = "root";
            connectionBuilder.Password = "bitminds";
        }

        public LoginDTO Perform(string documento, int tipo)
        {
            string query = $"SELECT u.password, u.rol FROM usuarios u WHERE documento='{documento}' AND tipo_doc={tipo}";
            LoginDTO loginDTO;

            using (MySqlConnection conn = new MySqlConnection(connectionBuilder.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                if (!reader.HasRows) return null;

                loginDTO = new LoginDTO
                (
                    reader["password"].ToString(),
                    (int)reader["rol"]
                );
            }
            
            return loginDTO;
        }
    }
}
