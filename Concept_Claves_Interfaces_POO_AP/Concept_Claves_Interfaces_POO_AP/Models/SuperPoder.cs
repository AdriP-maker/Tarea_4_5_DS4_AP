
namespace Concept_Claves_Interfaces_POO_AP.Models
{
    class SuperPoder
    {
        public string Nombre;
        public string Descripcion;
        public NivelPoder Nivel;
        public TipoPoder Tipo;

        public SuperPoder()
        {
            Nivel = NivelPoder.NivelUno;
            Tipo = TipoPoder.Movimiento;
        }
    }

}
