using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program15
    {
        static void Main(string[] args)
        {
            //opcion 1
            LineaDeCompra l1 = new LineaDeCompra(1,1,"Agua");
            LineaDeCompra l2 = new LineaDeCompra(2,3,"Galletas");
            List<LineaDeCompra> lista = new List<LineaDeCompra>();
            lista.Add(l1);
            lista.Add(l2);
            Compra c1 = new Compra(1, lista);
            Console.WriteLine("El importe total de la compra es "+c1.ImporteTotal);
            Console.WriteLine("El importe total de la compra con IVA es " + c1.ImporteTotalConIVA);



            //opcion 2
            Compra c = new Compra(1);
            c.AddLinea(new LineaDeCompra(1, 15, "Agua"));
            c.AddLinea(new LineaDeCompra(2, 10, "Pasta"));
            Console.WriteLine("El importe total de la compra es " + c.ImporteTotal);
            Console.WriteLine("El importe total de la compra con IVA es " + c.ImporteTotalConIVA);


            //opcion 2.1 importe con iva
            Console.WriteLine("El importe total de la compra con IVA es " + c.ImporteConIVA());

            Console.ReadLine();
        }

      
    }
}
