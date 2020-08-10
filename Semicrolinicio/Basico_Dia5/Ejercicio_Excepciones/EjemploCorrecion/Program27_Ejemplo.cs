using ES.Semicrol.Fundanet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia5
{
    class Program27_Ejemplo
    {
        static void Main(string[] args)
        {


            try
            {
                Persona3_Ejemplo p = new Persona3_Ejemplo("Lucas", 1201);
                Console.WriteLine(p.Edad);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            Console.ReadLine();


        }
    }
    }

