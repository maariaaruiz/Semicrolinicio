using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program9
    {
        static void Main(string[] args)
        {
            Rectangulo r1 = new Rectangulo(6,2);
          
            Console.WriteLine("El perimetro del rectangulo es "+r1.CalcularPerimetro());
            Console.WriteLine("El area del rectangulo es " + r1.CalcularArea());
        
            
            Console.ReadLine();

        }

      
    }
}
