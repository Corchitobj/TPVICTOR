using Chomper.Clase_Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chomper.Clases_Escuela
{
    internal class Materia
    {
        public string materia { get; set; }

        public int codigoMateria { get; set; }

        public Docentes docente { get; set; }
    }
}
