using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program14
    {
        static void Main(string[] args)
        {

            Alumno alumno1 = new Alumno("Pedro");
            alumno1.AddNota(new Nota(7));
            alumno1.AddNota(new Nota(10));

           
           
            Console.WriteLine("La nota mayor es " +alumno1.NotaMayor().Valor);
            Console.WriteLine("La nota media es "+alumno1.NotaMedia().Valor);
            Console.WriteLine("El tipo de la nota media es "+alumno1.NotaMedia().GetTipo());

            Console.ReadLine();

        }

      
    }
}
