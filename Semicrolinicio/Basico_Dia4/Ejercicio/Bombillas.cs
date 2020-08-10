using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejercicio
{
    class Bombillas :IEncendibleCocina
        
        //: IEncendibleCocinaIEncendibleVoz
    {
        //podemos utilizar solo la interfaz IEncendibleCocina
        //y tener  bombillasVoz como clase que herede de esta
        public void Encender()
        {
            Console.WriteLine("Las bombillas se encienden");
        }

        public void Apagar()
        {
            Console.WriteLine("Las bombillas se apagan");
        }

        //public void ApagarPorVoz()
        //{
        //    Console.WriteLine("Las bombillas se apagan");
        //}

        //public void EncenderPorVoz()
        //{
        //    Console.WriteLine("Las bombillas se encienden");
        //}
    }
}
