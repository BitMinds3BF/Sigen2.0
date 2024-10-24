using BCrypt.Net;
using BITMINDS.modelos;
using BITMINDS.repositorios.cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BITMINDS.services
{
    public class FormularioUsuarioService
    {
        private ClienteRepositorio ClienteRepositorio = new ClienteRepositorio();
        private string contraseñaGenerada;
        public string GenerarContraseña()
        {
            var random = new Random();
            var caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabscdefgijklmnopqrstuvwxyz0123456789";
            contraseñaGenerada = new string(Enumerable.Repeat(caracteres, 8)
                .Select(c => c[random.Next(c.Length)])
                .ToArray()
            );
            return contraseñaGenerada;
        }

        public string ObtenerContraseñaEncriptada()
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(contraseñaGenerada);
        }

        public void GuardarUsuario(Cliente cliente)
        {
            if (cliente.TipoDoc != "documento" && cliente.TipoDoc != "pasaporte")
            {
                throw new Exception("Tipo de documento invalido");
            }

            if (cliente.Email == string.Empty && cliente.Nombre == string.Empty &&
                cliente.Apellido == string.Empty && cliente.Departamento == string.Empty &&
                cliente.Calle == string.Empty && cliente.Numero == string.Empty)
            {
                throw new Exception("No se puede tener campos vacios");
            }

            if (cliente.Email == "Email" && cliente.Nombre == "Nombre" &&
                cliente.Apellido == "Apellido" && cliente.Departamento == "Departamento" &&
                cliente.Calle == "Calle")
            {
                throw new Exception("Hay campos con valores incorrectos como: Email, Nombre, Apellido, Departamento y Calle");
            }

            if (cliente.NumDoc.Trim().ToCharArray().TakeWhile(c => !char.IsDigit(c)).Count() > 0)
            {
                throw new Exception("El documento no es valido");
            }

            if (cliente.Numero.Trim().ToCharArray().TakeWhile(c => !char.IsDigit(c)).Count() > 0)
            {
                throw new Exception("El numero de la calle no es valido");
            }

            if (!VerificarEmail(cliente.Email))
            {
                throw new Exception("El email no es valido");
            }

            if (contraseñaGenerada == null)
            {
                throw new Exception("No se ha generado una contraseña");
            }

            ClienteRepositorio.Insertar(cliente);
            int idUsuario = ClienteRepositorio.InsertarUsuario(cliente, ObtenerContraseñaEncriptada());
            ClienteRepositorio.InsertarLoguea(cliente.NumDoc, cliente.TipoDoc, idUsuario);
        }

        private bool VerificarEmail(string email)
        {
            //Patron sacado de https://referencesource.microsoft.com/#System.ComponentModel.DataAnnotations/DataAnnotations/EmailAddressAttribute.cs
            string patron = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$";
            //IngoreCase para ignorar mayusculas
            var regex = new Regex(patron, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
    }
}
