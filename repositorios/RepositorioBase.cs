using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITMINDS.repositorios
{
    public class RepositorioBase
    {
        private MySqlConnectionStringBuilder connectionBuider;
        protected string ConnectionString { get { return connectionBuider.ConnectionString; } }

        public RepositorioBase()
        {
            connectionBuider = new MySqlConnectionStringBuilder();
            connectionBuider["Server"] = "localhost";
            connectionBuider["Database"] = "sigen";

            connectionBuider.UserID = "root";
            connectionBuider.Password = "bitminds";
        }
    }
}
