using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Gato : Animal
    {
        public string Cascabel { get; set; }
      

        public Gato(int peso, string color) : base(peso, color)
        {
        }

        public override void Vacunar()
        {
            Console.WriteLine("Vacunamos al gato con 1 inyección");
            estaVacunado = true;
        }
    }
}
