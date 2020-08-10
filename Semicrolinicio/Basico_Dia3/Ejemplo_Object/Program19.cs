using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program19
    {
        static void Main(string[] args)
        {

            Alquiler a1 = new AlquilerJoven(1, 200);
            Alquiler a2 = new AlquilerJoven(2, 300);
            Alquiler a3 = new AlquilerJoven(3, 400);
            Alquiler a4 = new AlquilerJoven(4, 500);

            //Alquiler a5 = new AlquilerVip(1, 500);
            //Alquiler a6 = new AlquilerVip(1, 600);
            //Alquiler a7 = new AlquilerVip(1, 700);

            Empresa e = new Empresa();
            e.AddAlquiler(a1);
            e.AddAlquiler(a2);
            e.AddAlquiler(a3);
            e.AddAlquiler(a4);
            //e.AddAlquiler(a5);
            //e.AddAlquiler(a6);
            //e.AddAlquiler(a7);

           
            e.CalcularImporteTotal();
            e.EliminarAlquiler(a4);
            Console.WriteLine("Quedan: "+e.NumeroAlquileres()+" alquileres");
            Console.WriteLine("Contiene el alquiler "+a3.Numero+" : "+e.ContieneAlquiler(a3));

            Console.WriteLine("El alquiler mas caro cuesta: "+e.AlquilerMasCaro().ImporteFinal());


           
            Console.ReadLine();
        }
    }
    }

