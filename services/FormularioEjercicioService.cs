using BITMINDS.modelos;
using BITMINDS.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITMINDS.services
{
    public class FormularioEjercicioService
    {
        private EjercicioRepositorio repositorio = new EjercicioRepositorio();
        private RutinaRepositorio rutinaRepositorio = new RutinaRepositorio();
        public void GuardarEjercicio(Ejercicio ejercicio)
        {
            if (ejercicio.Nombre == string.Empty &&
                ejercicio.Descripcion == string.Empty)
            {
                throw new Exception("No se puede tener campos vacios");
            }

            if (ejercicio.Nombre ==  "Nombre" ||  ejercicio.Descripcion == "Descripcion")
            {
                throw new Exception("Hay campos (Nombre o Descripcion) con el valor por defecto.");
            }

            if (ejercicio.GrupoMuscular != "piernas" && ejercicio.GrupoMuscular != "brazos" &&
                ejercicio.GrupoMuscular != "pectorales" && ejercicio.GrupoMuscular != "espalda" &&
                ejercicio.GrupoMuscular != "hombros")
            {
                throw new Exception("Grupo muscular invalido");
            }

            if (ejercicio.Tipo != "empuje" && ejercicio.Tipo != "jalon")
            {
                throw new Exception("Tipo de ejercicio invalido");
            }

            if (ejercicio.Id > 0)
            {
                repositorio.Actualizar(ejercicio);
            }
            else
            {
                repositorio.Insertar(ejercicio);

            }
        }

        public List<int> Rutinas() => rutinaRepositorio.ObtenerRutinas();
        public Ejercicio ObtenerEjercicio(int id) => repositorio.ObtenerEjercicio(id);
    }
}
