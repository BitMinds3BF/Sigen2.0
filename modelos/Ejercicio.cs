using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITMINDS.modelos
{
    public class Ejercicio
    {
        public int Id { get; set; } 
        public string Nombre { get; set; } 
        public string Descripcion { get; set; }
        public string GrupoMuscular {  get; set; }
        public string Tipo {  get; set; }
        public int Rutina { get; set; }
    }
}
