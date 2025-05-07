using Chomper.Clase_Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chomper.Clases_Escuela
{
    internal class Curso
    {
        public string anio { get; set; }
        public string division { get; set; }
        public Preceptor preceptorResponsable { get; set; }
    }
}
