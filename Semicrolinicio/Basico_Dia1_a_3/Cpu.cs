using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Cpu
    {
        public string Procesador { get; set; }
        public string RAM { get; set; }
        public int Nucleos { get; set; }


        public virtual void Encender()
        {
            Console.WriteLine("Encendiendo Cpu");
        }

        public virtual void Apagar()
        {
            Console.WriteLine("Apagando Cpu");
        }

    }
}
