using ES.Semicrol.Fundanet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejemplo_Bolsa
{
    class Program25
    {
        static void Main(string[] args)
        {
            //parte 1
            Bolsa<Golosina> bolsa = new Bolsa<Golosina>(5);
            bolsa.AddElemento(new Golosina("Fresa")); 
            bolsa.AddElemento(new Golosina("Limon")); 
            bolsa.AddElemento(new Golosina("Naranja")); 
            bolsa.AddElemento(new Golosina("Platano"));

            foreach (Golosina g in bolsa.Elementos)
            {
                Console.WriteLine(g.Sabor);
            }
            Console.WriteLine("\n");
            Golosina a = new Golosina("Limon");
            Golosina b = new Golosina("Fresa");
          

            //parte 2
            Pack<Golosina, Golosina> mipack = new Pack<Golosina, Golosina>(a,b);
            Console.WriteLine(mipack.Elemento1.Sabor);
            Console.WriteLine(mipack.Elemento2.Sabor);
         

            Console.ReadLine();


        }
    }
    }

