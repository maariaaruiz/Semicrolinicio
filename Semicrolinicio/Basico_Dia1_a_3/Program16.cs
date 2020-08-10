using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program16
    {
        static void Main(string[] args)
        {
            Televisor t = new Televisor();
            t.NumeroSerie = 100;
            t.Pulgadas = 50;
            t.Encender();

            Console.ReadLine();
        }
    }
}
