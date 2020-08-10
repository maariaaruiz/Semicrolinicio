using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class LineaDeCompra
    {
        public int Numero { get; set; }
        public double Importe { get; set; }
        public string Concepto {get;set;}

        public LineaDeCompra(int numero, double importe, string concepto)
        {
            this.Numero = numero;
            this.Importe = importe;
            this.Concepto = concepto;
        }

        //opcion 2 con iva, la mejor opcion
        public double ImporteconIVA()
        {
            return Importe*1.21;
        }

  

    }
}
