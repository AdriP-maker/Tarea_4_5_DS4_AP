using Concept_Claves_Interfaces_POO_AP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept_Claves_Interfaces_POO_AP
{
    internal class PrintInfo
    {
        public void Print_Sup_Heroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"Id: {superHeroe.Id}");
            Console.WriteLine($"Nombre: {superHeroe.Id}");
            Console.WriteLine($"Su identidad secreta es: {superHeroe.Id}");
        }
    }
}
