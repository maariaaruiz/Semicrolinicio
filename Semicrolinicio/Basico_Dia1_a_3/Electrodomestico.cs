using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Electrodomestico
    {
        public int NumeroSerie { get; set; }

        public virtual void Encender()
        {
            Console.WriteLine("El electrodomestico se enciende");
        }
        public virtual void Apagar()
        {
            Console.WriteLine("El electrodomestico se apaga");
        }
    }
}
