using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejemplo_Bolsa
{
    class Bolsa<T> where T:IPrecio
    {
        public int Tope { get; set; }
        public List<T> Elementos = new List<T>();

        public Bolsa(int tope)
        {
            Tope = tope;
        }

        public void AddElemento(T elemento)
        {
            if (Elementos.Count<Tope)
            {
                Elementos.Add(elemento);
            }
          
        }
        public void RemoveElemento(T elemento)
        {
            Elementos.Remove(elemento);
        }

        public double Total()
        {
            double _total = 0;
            foreach(T elemento in Elementos)
            {
                _total += elemento.Importe;

            }
            return _total;
        }
       
    }
}
