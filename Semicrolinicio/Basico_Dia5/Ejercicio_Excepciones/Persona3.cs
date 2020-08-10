using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Persona3
    {
        public Persona3(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string Nombre { get; set; }
        private int _edad;
        public int Edad{ get
            {
                return _edad;

            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Edad menor a la admitida");
                }
                else if (value> 120)
                {
                    throw new Exception("Edad mayor a la admitida");
                }
                else
                {
                    _edad = value;
                }
            }
            }

    }

   
}
