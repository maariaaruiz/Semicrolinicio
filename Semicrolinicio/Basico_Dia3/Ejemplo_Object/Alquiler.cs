using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Alquiler
    {
        public int Numero { get; set; }
        public double Importe { get; set; }

        public Alquiler()
        {

        }
        public Alquiler(int numero, int importe)
        {
            Numero = numero;
            Importe = importe;
        }

        public virtual double ImporteFinal()
        {
            return Importe * 1.21;
        }

        //con el metodo 2, estos dos metodos sobran
        public Alquiler ElegirMasCaro(Alquiler otra)
        {
            return Alquiler.ElegirMasCaro(this, otra);
        }
        public static  Alquiler ElegirMasCaro(Alquiler a1,Alquiler a2)
        {

            if (a1.ImporteFinal() > a2.ImporteFinal())
            {
                return a1;
            }
            else
            {
                return a2;
            }
        }

        public override bool Equals(object obj)
        {
            var alquiler = obj as Alquiler;
            return alquiler != null &&
                   Numero == alquiler.Numero &&
                   Importe == alquiler.Importe;
        }

        public override int GetHashCode()
        {
            var hashCode = -1858188936;
            hashCode = hashCode * -1521134295 + Numero.GetHashCode();
            hashCode = hashCode * -1521134295 + Importe.GetHashCode();
            return hashCode;
        }
    }

}
