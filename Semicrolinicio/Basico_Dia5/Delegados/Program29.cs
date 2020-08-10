using ES.Semicrol.Fundanet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia5
{
    class Program29
    {
        //era necesario declarar una funcion especial
        //recibe 2 parametros T1 y T2 y devuelve T3
        public delegate int Operacion(int a, int b);

        static void Main(string[] args)
        {
            //si utilizamos la funcion generica , no nos hace falta utilizar el delegado
        //opcion 1
            //  Func<int, int, int> MiFuncion=Sumar;//funcion que necesita dos parametros y devuelve uno
        //opcion 2
            Func<int, int, int> MiFuncion=(a,b)=>a*b;
            OperarPorPantalla(2, 3,Sumar);
            OperarPorPantalla(2, 3,Restar);
            OperarPorPantalla(2, 2,MiFuncion);
            OperarPorPantalla(8, 4,(a,b)=>a/b);
         
            Console.ReadLine();


        }
        public static int Sumar(int a,int b)
        {
            return a+b;
        }
        public static int Restar(int a,int b)
        {
            return a-b;
        }

        //opcion1
        //public static void OperarPorPantalla(int a,int b,Operacion tipoOperacion)
        //{
        //    Console.WriteLine("********");
        //    Console.WriteLine(tipoOperacion(a,b));
        //    Console.WriteLine("********");

        //}

        //opcion2
        public static void OperarPorPantalla(int a,int b,Func <int,int,int> tipoOperacion)
        {
            Console.WriteLine("********");
            Console.WriteLine(tipoOperacion(a,b));
            Console.WriteLine("********");

        }

    }
}

