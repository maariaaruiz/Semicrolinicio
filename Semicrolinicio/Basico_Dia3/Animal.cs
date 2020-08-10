using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    abstract class Animal
    {
        public int Peso { get; set; }
        public string Color { get; set; }
        public bool estaVacunado { get; set; }

        public Animal(int peso, string color)
        {
            Peso = peso;
            Color = color;
        }

        public abstract void Vacunar();

        public override bool Equals(object obj)
        {
            var animal = obj as Animal;
            return animal != null &&
                   Peso == animal.Peso &&
                   Color == animal.Color;
        }

        public override int GetHashCode()
        {
            var hashCode = 217452000;
            hashCode = hashCode * -1521134295 + Peso.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Color);
            return hashCode;
        }
    }
}
