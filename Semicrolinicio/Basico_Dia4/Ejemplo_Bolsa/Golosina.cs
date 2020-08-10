using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejemplo_Bolsa
{
    class Golosina:IPrecio
    {
        public string Sabor { get; set; }
        public double Importe { get; set; }

        public Golosina(string sabor)
        {
            this.Sabor = sabor;
        }
     
    }
}
