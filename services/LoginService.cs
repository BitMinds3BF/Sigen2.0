using BITMINDS.modelos;
using BITMINDS.repositorios.cliente;
using System;

namespace BITMINDS.services.login
{
    public class LoginService
    {
        private ClienteRepositorio Repositorio = new ClienteRepositorio();
        public Cliente Login(string documento, string tipo, string contraseña)
        {
            if (tipo != "documento" && tipo != "pasaporte")
            {
                throw new Exception("Por favor, seleccione el tipo de documento");
            }

            if (documento.Length == 0)
            {
                throw new Exception($"Por favor, introduce tu {tipo.ToLower()}");
            }

            Cliente cliente = Repositorio.ObtenerCliente(documento, tipo, true);

            if (cliente == null)
            {
                throw new Exception("No encontramos este cliente");
            }

            if (!cliente.VerificarContraseña(contraseña))
            {
                throw new Exception("Contraseña incorrecta");
            }


            return cliente;
        }
    }
}
