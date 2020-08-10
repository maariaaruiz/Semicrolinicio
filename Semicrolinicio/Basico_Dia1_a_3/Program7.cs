using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program7
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Nombre = "Pedro";
            p1.Apellidos = "Alvarez";
            p1.Edad = 20;
            Console.WriteLine(p1.Nombre);
            Console.WriteLine(p1.Apellidos);
            Console.WriteLine(p1.Edad);
            Console.WriteLine("Le quedan "+p1.TiempoParaJubilarse()+" años para jubilarse");
            
            Console.ReadLine();

        }

      
    }
}
