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
                ejercicio.GrupoMuscular != "pecho" && ejercicio.GrupoMuscular != "espalda" &&
                ejercicio.GrupoMuscular != "hombros")
            {
                throw new Exception("Grupo muscular invalido");
            }

            if (ejercicio.Tipo != "empuje" && ejercicio.Tipo != "jalon")
            {
                throw new Exception("Tipo de ejercicio invalido");
            }

            repositorio.Insertar(ejercicio);
        }
    }
}
