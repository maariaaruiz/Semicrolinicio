using ES.Semicrol.Fundanet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejercicio
{
    class Program23
    {
        static void Main(string[] args)
        {
            //IEncendibleCocinaIEncendibleVoz c = new Cocina();
            //c.Encender();
            //Console.WriteLine("\n");
            //c.EncenderPorVoz();

            //2a opcion
            Cocina c = new Cocina();
            c.AddEncendible(new Bombillas());
            c.AddEncendible(new Bombillas());
            c.AddEncendible(new BombillasVoz("1"));
            //distintas opciones
            //c.AddEncendible(new Frigorifico());
          //  c.AddEncendible(new EnchufeSmartAdaptador("2", new Frigorifico()));
           // c.EncenderTodo();
            c.EncenderPorVoz("2");

            Console.ReadLine();


        }
      
    }
    }

