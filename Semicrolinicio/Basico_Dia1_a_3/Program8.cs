using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program8
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura(5,"ordenador",500);
            Console.WriteLine(f1.Numero);
            Console.WriteLine(f1.Concepto);
            Console.WriteLine(f1.Importe);
            Console.WriteLine("El importe con IVA es "+f1.ImporteConIVA());
            Console.WriteLine("El importe con IVA variado es "+f1.ImporteConIVA(10));
            
            Console.ReadLine();

        }

      
    }
}
