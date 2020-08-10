using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Portatil : Ordenador
    {
        //opcion 1
        //public Portatil(Cpu cpu, Monitor monitor) : base(cpu, monitor)
        //{
        //}

        //opcion 2
        public Portatil(Cpu cpu) : base(cpu, new Monitor(15))
        {
          
        }
        //opcion 1
        //public override void Encender()
        //{
        //    Console.WriteLine("El portátil se enciende lentamente");
        //    base.Encender();
        //    Console.WriteLine("El portátil termino de encender");
        //}

        //opcion 2
        public override void Encender()
        {
            Console.WriteLine("El portátil se enciende lentamente");
            base.EncenderCPU();
            Console.WriteLine("El portátil termino de encender");
        }


    }
}
