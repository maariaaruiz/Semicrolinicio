using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4
{
    class Segway : IConducible,IConectable
    {
        public void Arrancar()
        {
            Console.WriteLine("El segway arranca");
        }

        public void Avanzar()
        {
            Console.WriteLine("El segway avanza");
        }

        public void Desconectar()
        {
            Console.WriteLine("El segway esta desconectado");
        }

        public void Conectar()
        {
            Console.WriteLine("El segway esta conectado");
        }

        public void Girar()
        {
            Console.WriteLine("El segway gira");
        }

        public void Parar()
        {
            Console.WriteLine("El segway para");
        }
    }
}
