using ES.Semicrol.Fundanet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia5
{
    class Program28
    {
        //delegado
        delegate int Operacion(int a, int b);
        
        static void Main(string[] args)
        {

            //SIN DELEGADOS
            // int resultado = Sumar(2, 2);//aqui no se usa delegados
            //Console.WriteLine(resultado);

            //CON DELEGADOS
            Operacion o=new Operacion(Sumar);
            int resultado =o(2, 2);
            Console.WriteLine(resultado);
            Console.ReadLine();


        }

        public static int Sumar(int a,int b)
        {
            return a + b;
        }
    }
}

