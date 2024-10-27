using BITMINDS.modelos;
using BITMINDS.repositorios;
using BITMINDS.repositorios.cliente;
using System;
using System.Collections.Generic;

namespace BITMINDS.services
{
    public class ClienteService
    {
        private ClienteRepositorio ClienteRepositorio = new ClienteRepositorio();
        private EjercicioRepositorio ejercicioRepositorio = new EjercicioRepositorio();

        public ClienteService(string documento, string tipoDocumento)
        {
            this.documento = documento;
            this.tipoDocumento = tipoDocumento;
        }

        public Cliente MisDatos()
        {
            Cliente cliente = ClienteRepositorio.ObtenerCliente(documento, tipoDocumento);

            if (cliente == null) throw new Exception();

            return cliente;
        }

        public List<EjercicioAsignado> MisEjercicios() => ejercicioRepositorio.ObtenerEjerciciosAsignados(documento, tipoDocumento);

        public EjercicioAsignado MarcarEjercicioCompletado(EjercicioAsignado ejercicio)
        {
            ejercicio.Realizado = DateTime.Now.ToString("yyyy-MM-dd");
            ejercicioRepositorio.GuardarEjercicioAsignadoCompletado(ejercicio, documento, tipoDocumento);
            return ejercicio;
        }

        private string documento;
        private string tipoDocumento;
    }
}
