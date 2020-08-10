using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Nota
    {
        public double Valor { get; set; }
        public string GetTipo()
        {
            if (Valor > 0 && Valor <= 3)
            {

                return "Insuficiente";
            }
            else if (Valor >= 4 && Valor <= 5)
            {

                return "Suficiente";
            }
            else if (Valor >= 6 && Valor < 7)
            {

                return "bien";
            }
            else if (Valor >= 7 && Valor <= 8)
            {
                return "Notable";
            }
            else 
            {
                return "Sobresaliente";
            };


        }

        public Nota(double valor)
        {
            Valor = valor;
        }

        public Nota()
        {

        }

        // que pertenecera a un objeto
        // metodo de instancia
        public Nota ElegirMayor(Nota otra)
        {
            return Nota.ElegirMayor(this, otra);
        }

        public static Nota ElegirMayor(Nota nota1, Nota nota2)
        {
            // this hace referenia 
            // al objeto actual

            if (nota1.Valor > nota2.Valor)
            {
                return nota1;
            }
            else
            {
                return nota2;
            }
        }




    }
}


