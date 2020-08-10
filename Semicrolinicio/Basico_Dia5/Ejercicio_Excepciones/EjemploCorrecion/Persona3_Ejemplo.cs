using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Persona3_Ejemplo
    {
        public Persona3_Ejemplo(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string Nombre { get; set; }
        private int _edad;
        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                if (value < 0 || value >120)
                {
                    throw new Exception("Edad no valida");
                }
                else
                {
                    _edad = value;
                }
            }

        }
    }

   
}
