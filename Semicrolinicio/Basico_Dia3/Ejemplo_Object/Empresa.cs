using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Empresa
    {
       
        public List<Alquiler> Alquileres{get;set; }

        public Empresa()
        {
            Alquileres = new List<Alquiler>();
        }

        public void AddAlquiler(Alquiler a) {
            this.Alquileres.Add(a);

        }
        public void CalcularImporteTotal()
        {
            double ImporteTotal=0;
            foreach(Alquiler a in Alquileres)
            {
                ImporteTotal+=a.ImporteFinal();
            }
            Console.WriteLine("El importe total es " + ImporteTotal);
        }

        public Alquiler AlquilerMasCaro() {
            //opcion1 
            Alquiler alquilerMayor = new Alquiler();
            //opcion2
            //Alquiler alquilerMayor=Alquileres[0];
            foreach (Alquiler alquiler in Alquileres)
            {
                //opcion1
                alquilerMayor = alquiler.ElegirMasCaro(alquilerMayor);

                //opcion2 
                /* if(alquiler.ImporteFinal() > alquilerMayor.ImporteFinal(){
                 * alquilerMayor=alquiler;
                 * */
            }
            return alquilerMayor;
        }

        public void EliminarAlquiler(Alquiler a)
        {
            this.Alquileres.Remove(a);
        }

        public int NumeroAlquileres()
        {
            return  this.Alquileres.Count;
           
        }

        public bool ContieneAlquiler(Alquiler a)
        {
            return this.Alquileres.Contains(a);
        }

    }

    
}
