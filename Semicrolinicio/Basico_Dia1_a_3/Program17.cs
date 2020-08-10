using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program17
    {
        static void Main(string[] args)
        {
            Ordenador o1 = new Ordenador(new Cpu(), new Monitor(15));
            o1.Encender();

            Portatil p = new Portatil(new Cpu());
            p.Encender();
            Console.ReadLine();
        }
    }
}
