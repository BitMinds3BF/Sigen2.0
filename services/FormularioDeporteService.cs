using BITMINDS.modelos;
using BITMINDS.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITMINDS.services
{
    public class FormularioDeporteService
    {
        private DeporteRepositorio repositorio = new DeporteRepositorio();
        public void GuardarDeporte(Deporte deporte)
        {
            if (deporte.Nombre == string.Empty || deporte.Nombre == "Deporte")
            {
                throw new Exception("El nombre del deporte no puede estar vacio");
            }

            if (deporte.Id > 0)
            {
                repositorio.Actualizar(deporte);

            }
            else 
            {
                repositorio.Insertar(deporte);
            }
            
        }

        public Deporte ObtenerDeporte(int id) => repositorio.ObtenerDeporte(id);
    }
}
