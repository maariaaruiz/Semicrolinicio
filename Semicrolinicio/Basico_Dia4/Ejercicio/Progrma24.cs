using ES.Semicrol.Fundanet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejercicio
{
    class Program24
    {
        //esta clase la utilizamos para probar la interfaz IComparable<>
        static void Main(string[] args)
        {

            List<Frigorifico> lista = new List<Frigorifico>();
            lista.Add(new Frigorifico(20));
            lista.Add(new Frigorifico(20));
            lista.Add(new Frigorifico(30));
            lista.Add(new Frigorifico(60));
            lista.Add(new Frigorifico(10));
            lista.Sort(new ComparadorPotencia());

            foreach (Frigorifico f in lista)
            {
                Console.WriteLine(f.Potencia);
            }
            Console.ReadLine();


        }
      
    }
    }

