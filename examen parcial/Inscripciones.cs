using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_parcial
{
    internal class Inscripciones
    {
        int dpiAlumnos;
        int codTaller;
        DateTime fecha;

        public int DpiAlumnos { get => dpiAlumnos; set => dpiAlumnos = value; }
        public int CodTaller { get => codTaller; set => codTaller = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
