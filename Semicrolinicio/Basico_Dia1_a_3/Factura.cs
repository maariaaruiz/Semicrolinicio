using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Factura
    {
        private int _numero;
        private string _concepto;
        private double _importe;

        public Factura()
        {
        }

        public Factura(int numero)
        {
            Numero = numero;
        }

        public Factura(int numero, string concepto, double importe)
        {
            _numero = numero;
            _concepto = concepto;
            _importe = importe;
        }

        public int Numero { get => _numero; set => _numero = value; }
        public string Concepto { get => _concepto; set => _concepto = value; }
        public double Importe { get => _importe; set => _importe = value; }


        public double ImporteConIVA()
        {
          return Importe*1.21;
        }

        //sobrecarga de metodos
        //si le das el mismo nombre, pero le envias argumentos
        public double ImporteConIVA(int porcentaje)
        {
            return _importe+(_importe * porcentaje/100);
        }
    }

   
}
