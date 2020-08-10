using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program13
    {
        static void Main(string[] args)
        {


            List<Nota> misNotas = new List<Nota>();
            misNotas.Add(new Nota(3));
            misNotas.Add(new Nota(4));
            misNotas.Add(new Nota(5));
            misNotas.Add(new Nota(6));
            misNotas.Add(new Nota(7));
            misNotas.Add(new Nota(8));

            foreach(Nota n in misNotas)
            {
                Console.WriteLine(n.Valor);
            }

            Nota notaMayor=new Nota();
            foreach(Nota n in misNotas)
            {
                notaMayor = n.ElegirMayor(notaMayor);

            }
            Console.WriteLine("La nota mayor es " + notaMayor.Valor);


            double media = 0;
            foreach (Nota n in misNotas)
            {            
                media = media +n.Valor;

            }

            Console.WriteLine("La media es " + media/misNotas.Count);

            Console.ReadLine();

        }

      
    }
}
