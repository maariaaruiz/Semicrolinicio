using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program10
    {
        static void Main(string[] args)
        {
            Nota n1 = new Nota(3);
            Nota n2 = new Nota(7);
            Console.WriteLine(n1.GetTipo());
            Console.WriteLine(n2.GetTipo());
            Console.WriteLine("La nota mayor es "+n2.ElegirMayor(n1).Valor);

            //mejor opcion
           // Nota nResult = n2.ElegirMayor(n1);
           // Console.WriteLine(nResult.Valor);

            Console.ReadLine();

        }

      
    }
}
