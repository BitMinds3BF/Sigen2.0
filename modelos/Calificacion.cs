using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITMINDS.modelos
{
    public class Calificacion
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Fecha { get; set; }
        public int PuntajeObtenido { get; set; }
    }
}
