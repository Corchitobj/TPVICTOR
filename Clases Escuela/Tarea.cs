using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chomper.Clases_Escuela
{
    internal class Tarea
    {
        public String titulo { get; set; }

        public String descripcion { get; set; }

        public int nota { get; set; }

        public DateTime fechaEntrega { get; set; }
    }
}
