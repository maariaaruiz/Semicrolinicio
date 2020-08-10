using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program18
    {
        static void Main(string[] args)
        {
            //opcion 1
            // Perro p1 = new Perro(90, "Blanco");

            //opcion 2
            // Animal p1 = new Perro(90, "Blanco"); 

            //opcion 3- factoría
            Animal p1 = FactoriaAnimales.GetAnimal("Perro", 30, "Blanco");
            Animal g1 = FactoriaAnimales.GetAnimal("Gato",30, "Blanco");

            //saca el nombre de la clase (tipo de clase)
            Console.WriteLine(p1.GetType().Name);

            VacunarAnimal(p1);
            VacunarAnimal(g1);

            Perro p2 = new Perro(20,"Negro");
            Perro p3 = new Perro(20,"Negro");

            Console.WriteLine("Son iguales: "+p2.Equals(p3));
            Console.ReadLine();
        }

        public static void VacunarAnimal(Animal a)
        {
            a.Vacunar();
          Console.WriteLine("Esta vacunado: "+a.estaVacunado);
        }
        
    }
}
