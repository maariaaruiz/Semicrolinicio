using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Ordenador
    {
    
        public string Marca{ get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string TargetaGrafica{ get; set; }
        public Cpu Cpu { get; set; }
        public Monitor Monitor { get; set; }

        public Ordenador(Cpu cpu, Monitor monitor)
        {
            Cpu = cpu;
            Monitor = monitor;
        }

        //public virtual void Encender()
        //{
        //    //desviamos a los metodos de cada CLASE
        //    //se le llama DELEGACION
        //    Cpu.Encender();
        //    Monitor.Encender();
        //    // Console.WriteLine("Encendiendo");
        //}

        //opcion 2
        public virtual void Encender()
        {
            EncenderCPU();
            EncenderMonitor();
        }
        protected virtual void EncenderCPU()
        {
            Cpu.Encender();
        }


        protected virtual void EncenderMonitor()
        {
            Monitor.Encender();
        }
        public virtual void Apagar()
        {
            Console.WriteLine("Apagando");
        }

        public virtual void Actualizar()
        {
            Console.WriteLine("Actualizar");
        }

        public virtual void Reiniciar()
        {
            Console.WriteLine("Reiniciar");
        }
        public virtual void Formatear()
        {
            Console.WriteLine("Formatear");
        }



    }
}
