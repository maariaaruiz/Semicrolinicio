using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejemplo_Bolsa
{
    class Chocolatina:IPrecio
    {
        public string TipoChocolate { get; set; }
        public double Importe { get; set ; }

        public Chocolatina(string tipochocolate)
        {
            this.TipoChocolate = tipochocolate;
        }
     
    }
}
