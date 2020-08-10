using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejercicio
{
    class BombillasVoz : Bombillas,IEncendibleVoz
    {
        public BombillasVoz(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
      
        public void ApagarPorVoz()
        {
            Console.WriteLine("Las bombillas por Voz se apagan");
        }

        public void EncenderPorVoz()
        {
            Console.WriteLine("Las bombillas  por Voz se encienden");
        }

        public override bool Equals(object obj)
        {
            var voz = obj as BombillasVoz;
            return voz != null &&
                   Id == voz.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<string>.Default.GetHashCode(Id);
        }
    }
}
