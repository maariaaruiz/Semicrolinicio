using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejemplo_Bolsa
{
    class Pack<T,K> where T : IPrecio where K : IPrecio
    {

        public T Elemento1 { get; set; }
        public K Elemento2 { get; set; }

        public Pack(T elemento1, K elemento2)
        {
            this.Elemento1 = elemento1;
            this.Elemento2 = elemento2;
        }

        public double Total()
        {
            double _total = 0;
            _total = Elemento1.Importe + Elemento2.Importe;
            return _total;
        }



    }
}
