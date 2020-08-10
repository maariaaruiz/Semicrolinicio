using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Paciente
    {
        public Paciente(string dNI, string nombre)
        {
            DNI = dNI;
            Nombre = nombre;
        }

        public Paciente(string dNI, string nombre,HistorialMedico historial):this(dNI,nombre)
        {
           //no inicializo los  campos porque delego en el constructor de dos parametros
           //si no tiene historial, pasa al constructor de dni y nombre
            Historial = historial;
        }

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public HistorialMedico Historial { get; set; }

    }
}
