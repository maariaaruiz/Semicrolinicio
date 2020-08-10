using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Compra
    {

        public int Numero { get; set; }
        //  public double importeTotal { get; set; }
        public List<LineaDeCompra> MisLineas { get; set; }
        public Compra(int numero)
        {
            Numero = numero;
            MisLineas = new List<LineaDeCompra>();
        }
        public Compra(int numero, List<LineaDeCompra> misLineas)
        {
            this.Numero = numero;
            this.MisLineas = misLineas;
        }

        public void AddLinea(LineaDeCompra linea)
        {
            MisLineas.Add(linea);
        }

        public double ImporteTotal
        {
            get{
                double total = 0;
                foreach (LineaDeCompra linea in MisLineas)
                {
                  total += linea.Importe;
                }
                return total;
            }
        }

        //opcion 1 importe total con IVA
        public double ImporteTotalConIVA
        {
            get
            {
                double total = 0;
                foreach (LineaDeCompra linea in MisLineas)
                {
                    total += linea.Importe;
                }
                return total *1.21;
            }
        }

        //opcion 2 con iva, la mejor opcion
        public double ImporteConIVA()
        {
           
                double total = 0;
                foreach (LineaDeCompra linea in MisLineas)
                {
                    total += linea.ImporteconIVA();
                }
                return total ;
            
        }


    }
}
