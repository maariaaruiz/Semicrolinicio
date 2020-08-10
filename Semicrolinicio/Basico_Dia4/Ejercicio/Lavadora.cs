using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejercicio
{
    class Lavadora : IEncendibleCocina
    {
        public void Apagar()
        {
            Console.WriteLine("La lavadora se apaga");
        }

        public void Encender()
        {
            Console.WriteLine("La lavadora se enciende");
        }
    }
}
