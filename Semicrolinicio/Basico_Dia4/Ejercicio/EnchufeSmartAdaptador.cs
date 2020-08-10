using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejercicio
{
    class EnchufeSmartAdaptador:IEncendibleVoz
    {
        public string Id { get; set; }
        public IEncendibleCocina Encendible { get; set; }

        public EnchufeSmartAdaptador(string id, IEncendibleCocina encendible)
        {
            Id = id;
            Encendible = encendible;
        }

        public void Encender()
        {
            Encendible.Encender();
        }

        public void Apagar()
        {
            Encendible.Apagar();
        }

        public void ApagarPorVoz()
        {
            Encendible.Apagar();
        }

        public void EncenderPorVoz()
        {
            Encendible.Encender(); 
        }
    }
}
