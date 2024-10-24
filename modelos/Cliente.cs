using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BITMINDS.modelos
{
    public class Cliente : Usuario
    {
        public string NumDoc { get; set; }
        public string TipoDoc { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Departamento { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }

        public Cliente() { }
        public Cliente(string contraseña) : base(contraseña) { }
    }
}
