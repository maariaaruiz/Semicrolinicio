using ES.Semicrol.Fundanet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia5
{
    class Program26
    {
        static void Main(string[] args)
        {
            //el @ es para no tener que escapar el caracter \
            string ruta = @"C:\Users\formacion\Desktop\prueba.txt";
           
            //parte2.1-leer fichero// StreamReader sr=null ;

            try
            {
                //parte1 
                // File.Create(ruta);
                // throw new Exception("Que mal vamos");

                //parte 2 - leer fichero forma 1
                //sr = File.OpenText(ruta);
                //string s = "";
                //while((s=sr.ReadLine()) != null)
                //{
                //    Console.WriteLine(s);
                //}

                //parte 2 -leer fichero parte 2 y mejor
                using(StreamReader sr = File.OpenText(ruta))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }


                Console.WriteLine("\n");

            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido una excepcion");
                Console.WriteLine(e.Message);
                Console.WriteLine("\n");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("\n");
               
            }
            finally
            {
               // sr.Close();
                Console.WriteLine("Todo termino");
            }
            Console.ReadLine();


        }
    }
    }

