using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program4
    {
        static void Main(string[] args)
        {

            int numero = 0;
            while (numero < 10)
            {
                Console.WriteLine(numero);
                numero = numero + 1; //numero++;
            }
            Console.ReadLine();

            /*actividad
             *   int numero = 0;
            int num = 5;
            Console.WriteLine("TABLA DEL " + num);
            for (int i = 0; i <= 10; i++)
            {
                numero = num * i;
               
                Console.WriteLine(num+" x " + i + " = "+numero);
            }
            Console.ReadLine();*/
        }
    }
}
