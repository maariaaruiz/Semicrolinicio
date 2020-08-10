using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Monitor
    {

        public int Pulgadas { get; set; }

        public Monitor(int pulgadas)
        {
            Pulgadas = pulgadas;
        }

        public virtual void Encender()
        {
            Console.WriteLine("Encendiendo monitor");
        }

        public virtual void Apagar()
        {
            Console.WriteLine("Apagando monitor");
        }
    }
}
