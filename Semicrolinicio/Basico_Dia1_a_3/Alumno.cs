using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Alumno
    {
        public string Nombre { get; set; }
        private List<Nota> _notas = new List<Nota>();
        // public Nota Nota { get; set; }

        public List<Nota> Notas
        {
            get
            {
                return _notas;
            }
            set
            {
                _notas = value;
            }
        }

        public Alumno(string nombre)
        {
            Nombre = nombre;
          
        }

        //public Alumno(string nombre, Nota nota)
        //{
        //    Nombre = nombre;
        //    Nota = nota;
        //}

        //añadimos notas
         public void AddNota(Nota n)
         {
           this.Notas.Add(n);
            
         }

       public Nota NotaMayor()
        {
            Nota notaMayor=new Nota();
           foreach(Nota nota in Notas)
            {
            notaMayor= nota.ElegirMayor(notaMayor);
            }
            return notaMayor;
        }

        public Nota NotaMedia()
        {
            double media = 0;
            Nota notaMedia = new Nota();
            foreach (Nota n in Notas)
            {
                media = media + n.Valor;

            }
           
            return new Nota(media /Notas.Count);
        }


    }
}
