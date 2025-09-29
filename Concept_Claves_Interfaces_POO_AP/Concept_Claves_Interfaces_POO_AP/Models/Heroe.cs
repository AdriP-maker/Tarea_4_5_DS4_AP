namespace Concept_Claves_Interfaces_POO_AP.Models
{
    internal abstract class Heroe
    {

        public abstract string Nom { get; set; }


        public abstract string SalvarelMundo();

        public virtual string SalvarLaTierra()
        {
            return $"{Nom} ha salvado la tierra, pero en el proceso se llevo la mitad de esta ";
        }
    }
}