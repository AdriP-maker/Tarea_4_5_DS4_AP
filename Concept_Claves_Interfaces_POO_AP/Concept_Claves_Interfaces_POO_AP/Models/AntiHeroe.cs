
namespace Concept_Claves_Interfaces_POO_AP.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string Contr_Act_Heroe (string accion)
        {
            return $"El AntiHeroe {Nom_SecretId} ha realizado el acto de : {accion}";
        }
    }
}
