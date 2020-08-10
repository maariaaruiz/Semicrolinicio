using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program6
    {
        static void Main(string[] args)
        {
            //operado new construye un objeto en memoria
            Madalena m1 = new Madalena();
            m1.Color = "amarillo";
            m1.Peso = 3;
            m1.Precio = 6;
           Console.WriteLine(m1.Precio);
            Console.WriteLine(m1.Color);
            Console.WriteLine(m1.Peso);

            Console.ReadLine();

        }

      
    }
}
