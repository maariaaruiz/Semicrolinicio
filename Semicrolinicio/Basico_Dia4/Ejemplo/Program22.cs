using ES.Semicrol.Fundanet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4
{
    class Program22
    {
        static void Main(string[] args)
        {

            IConducible miMoto = new Moto();
            miMoto.Avanzar();

            Console.WriteLine("\n");

            IConducibleIConectable miPatinete = new Patinete();
            Mover(miPatinete);

            Console.WriteLine("\n");

            IConectable miPatinete2 = new Patinete();
            miPatinete2.Conectar();
            miPatinete2.Desconectar();
            Console.ReadLine();


        }
        //metodo que utiliza todos los metodos de la interfaz IConducible
        public static void Mover(IConducible c)
        {
            c.Arrancar();
            c.Avanzar();
            c.Girar();
            c.Avanzar();
            c.Parar();
        }
    }
    }

