using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejercicio
{
    class Frigorifico : IEncendibleCocina,IComparable<Frigorifico>
    {
        public Frigorifico(int potencia)
        {
            Potencia = potencia;
        }

        public int Potencia { get; set; }
        public void Apagar()
        {
            Console.WriteLine("El frigorifico se apaga");
        }

        public int CompareTo(Frigorifico otroFigorifico)
        {
            if (otroFigorifico.Potencia < this.Potencia)
            {
                return -1;

            }else if(otroFigorifico.Potencia==this.Potencia){

                return 0;
            }
            else
            {
                return 1;
            }
        }

        public void Encender()
        {
            Console.WriteLine("El frigorifico se enciende");

        }
    }
}
