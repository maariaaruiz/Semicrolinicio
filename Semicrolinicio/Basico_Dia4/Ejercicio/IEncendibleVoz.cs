using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Basico_Dia4.Ejercicio
{
    interface IEncendibleVoz:IEncendibleCocina
    {
        string Id { get; set; }
        void EncenderPorVoz();
        void ApagarPorVoz();
    }
}
