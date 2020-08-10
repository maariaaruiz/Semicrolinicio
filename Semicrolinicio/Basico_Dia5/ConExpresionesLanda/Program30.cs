using ES.Semicrol.Fundanet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia5
{
    class Program30
    {
       static void Main(string[] args)
        {
            List<Persona3> Lista = new List<Persona3>();
            Lista.Add(new Persona3("Pepe",30));
            Lista.Add(new Persona3("Ana",40));
            Lista.Add(new Persona3("Maria",10));
            Lista.Add(new Persona3("Andres",50));

            IEnumerable<Persona3> resultado = Lista.Where((personita) => personita.Edad >= 40);
            
                foreach (Persona3 p in resultado)
                {
                    Console.WriteLine(p.Nombre);
                }
          
            Console.ReadLine();

        }

    }
}

