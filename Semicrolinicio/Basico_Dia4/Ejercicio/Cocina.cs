using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejercicio
{// :IEncendibleCocinaIEncendibleVoz
    class Cocina
    {
        public Bombillas B { get; set; }
        public Lavadora L { get; set; }
        public Frigorifico F { get; set; }
        
        //2a opcion
        public List<IEncendibleCocina> Encendibles { get; set; }
    

        
        public Cocina()
        {
           
            B = new Bombillas();
            L = new Lavadora();
           // F = new Frigorifico();

            //2a opcion
            Encendibles = new List<IEncendibleCocina>();
           
            
        }
        //2a opcion
        public void AddEncendible(IEncendibleCocina e)
        {
            Encendibles.Add(e);
         
          
        }
        //2a opcion
        public void EncenderTodo()
        {
            foreach(IEncendibleCocina e in Encendibles)
            {
                e.Encender();
            }
        }

        public void EncenderPorVoz(string id)
        {

            foreach (IEncendibleCocina e in Encendibles)
            {
                if(e is IEncendibleVoz)
                {
                IEncendibleVoz otro = (IEncendibleVoz)e;
                if (otro.Id.Equals(id))
                {
                    otro.EncenderPorVoz();
                }
                }
            }
            //if (e is BombillasVoz)
            //{
            //    EncendibleVoz.Add((IEncendibleVoz)e);
            //}
        }

        //public void Encender()
        //{
        //    B.Encender();
        //    L.Encender();
        //    F.Encender();
        //}

        //public void Apagar()
        //{
        //    B.Apagar();
        //    L.Apagar();
        //    F.Apagar();
        //}

        //public void EncenderPorVoz()
        //{
        //    B.EncenderPorVoz();
        //}

        //public void ApagarPorVoz()
        //{
        //    B.ApagarPorVoz();
        //}
    }
}
