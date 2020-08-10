using ES.Semicrol.Fundanet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia5
{
    class Program27
    {
        static void Main(string[] args)
        {
         
            try
            {
                Persona3 p = new Persona3("Lucas",121);

                Console.WriteLine(p);

            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido una excepcion");
                Console.WriteLine(e.Message);
                Console.WriteLine("\n");
              
               
            }
           
            Console.ReadLine();


        }
    }
    }

