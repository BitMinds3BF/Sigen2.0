using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITMINDS.modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Rol {  get; set; }
        protected string contraseña;

        protected Usuario() { }
        protected Usuario(string contraseña)
        {
            this.contraseña = contraseña;
        }

        public bool VerificarContraseña(string contraseña)
        {
            //this.contraseña es la contraseña encriptada que esta en la base de datos
            if (this.contraseña == null) throw new Exception();

            return BCrypt.Net.BCrypt.EnhancedVerify(contraseña, this.contraseña);
        }
    }
}
