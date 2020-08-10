using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Rectangulo
    {
        private int _ladoA;
        private int _ladoB;


        public Rectangulo()
        {
        }

        public Rectangulo(int ladoA, int ladoB)
        {
            _ladoA = ladoA;
            _ladoB = ladoB;
        }

        public int LadoA { get => _ladoA; set => _ladoA = value; }
        public int LadoB { get => _ladoB; set => _ladoB = value; }

        public int CalcularArea()
        {
          return Rectangulo.CalcularArea(this.LadoA,this.LadoB);
        }
        public static int CalcularArea(int LadoA,int LadoB)
        {
            return LadoA * LadoB;
        }
        public int CalcularPerimetro()
        {
            return (2 * LadoA)+(2*LadoB) ;
        }
    }

   
}
