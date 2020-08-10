using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4
{
    class Patinete :IConducibleIConectable
    {
        public void Arrancar()
        {
            Console.WriteLine("El patinete arranca");
        }

        public void Avanzar()
        {
            Console.WriteLine("El patinete avanza");
        }

        public void Conectar()
        {
            Console.WriteLine("El patinete esta conectado");
        }

        public void Desconectar()
        {
            Console.WriteLine("El patinete esta desconectado");
        }

        public void Girar()
        {
            Console.WriteLine("El patinete gira");
        }

        public void Parar()
        {
            Console.WriteLine("El patinete para");
        }
    }
}
