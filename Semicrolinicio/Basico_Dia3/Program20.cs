using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program20
    {
        static void Main(string[] args)
        {
            //inboxing
            bool verdadero = true;
            //outBoxing
            Boolean otroVerdadero = verdadero;

            bool otroMasVerdadero = otroVerdadero;
            Console.WriteLine(verdadero);
          
            int numero = 7;
            Console.WriteLine(numero);   
            Int32 numero2 = 2000;
            Console.WriteLine(numero2);

            List<Int32> lista = new List<Int32>();
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);

            foreach(Int32 num in lista)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();


        }
    }
    }

