using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program12
    {
        static void Main(string[] args)
        {

            HistorialMedico h1 = new HistorialMedico(123456, new DateTime(2020, 10, 10));
            Paciente p1 = new Paciente("72314523S", "Carmen", h1);

            Console.WriteLine(p1.Historial.NumeroHistorial);
            Console.WriteLine(p1.Historial.fecha);
            Console.WriteLine(p1.Nombre);
            Console.ReadLine();
        }
    }
}
