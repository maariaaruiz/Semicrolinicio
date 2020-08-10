using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class HistorialMedico
    {
        public HistorialMedico(int numeroHistorial, DateTime fecha)
        {
            NumeroHistorial = numeroHistorial;
            this.fecha = fecha;
        }

        public int NumeroHistorial { get; set; }
        public DateTime  fecha { get; set; }


    }
}
