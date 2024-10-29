using BITMINDS.modelos;
using BITMINDS.repositorios;
using BITMINDS.repositorios.cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITMINDS.services
{
    internal class ServiceUsuarioAvanzado
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        private EjercicioRepositorio ejercicioRepositorio = new EjercicioRepositorio();
        private DeporteRepositorio deporteRepositorio = new DeporteRepositorio();
        public List<Cliente> Clientes() => clienteRepositorio.ObtenerTodos();
        public List<Ejercicio> Ejercicios() => ejercicioRepositorio.ObtenerTodosEjercicios();
        public List<Deporte> Deportes() => deporteRepositorio.ObtenerDeportes();
        public void EliminarCliente(int id) => clienteRepositorio.Eliminar(id);
        public void EliminarEjercicio(int id) => ejercicioRepositorio.Eliminar(id);
        public void EliminarDeporte(int id) => deporteRepositorio.Eliminar(id);
    }
}
