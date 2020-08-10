using ES.Semicrol.Fundanet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program21
    {
        static void Main(string[] args)
        {
            Dictionary<String, Persona2> diccionario = new Dictionary<string, Persona2>();

            Persona2 p1 = new Persona2();
            p1.Nombre = "Pedro";
            p1.Apellidos = "Gomez";
            p1.Edad = 50;

            Persona2 p2 = new Persona2();
            p2.Nombre = "Ana";
            p2.Apellidos = "Perez";
            p2.Edad = 30;

            diccionario.Add(p1.Nombre, p1);
            diccionario.Add(p2.Nombre, p2);

            Console.WriteLine(diccionario["Pedro"].Apellidos);
            Console.WriteLine(diccionario["Pedro"].ToString());
          
            Console.WriteLine("\nLISTA DE PERSONAS");
            foreach (Persona2 p in diccionario.Values)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("\nLISTA DE NOMBRES DE LAS PERSONAS");
            foreach (String nombre in diccionario.Keys)
            {
                Console.WriteLine(nombre);
            }

            Telefono t = new Telefono();
            t.Numero = 12345679;
            Console.WriteLine("\nNumero de telefono : "+t.Numero);
        
        Console.ReadLine();


        }
    }
    }

