using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejercicio
{
    class ComparadorPotencia : IComparer<Frigorifico>
    {
        public int Compare(Frigorifico x, Frigorifico y)
        {
            if (x.Potencia > y.Potencia)
            {
                return 1;
            }else if (x.Potencia == y.Potencia)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
