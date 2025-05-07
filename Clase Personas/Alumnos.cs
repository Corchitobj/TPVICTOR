using Chomper.Clases_Escuela;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chomper.Clase_Personas
{
    internal class Alumnos
    {
        public int numeroMatricula { get; set; }
        List<Asistencia> asistencias;
        List<Nota> notas;
    }
}
