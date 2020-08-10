using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program2
    {
        static void Main(string[] args)
        {

            int numero = 9;

            if (numero > 0 && numero<3)
            {
                Console.WriteLine("Has sacado muy deficiente");
            }
            else if(numero >=3 && numero < 5)
            {
                Console.WriteLine("Has suspendido");
            }
            else if (numero >= 5 && numero < 7)
            {
                Console.WriteLine("Has aprobado");
            }
            else 
            {
                Console.WriteLine("Buena nota");
            }
            Console.ReadLine();
        }
    }
}
