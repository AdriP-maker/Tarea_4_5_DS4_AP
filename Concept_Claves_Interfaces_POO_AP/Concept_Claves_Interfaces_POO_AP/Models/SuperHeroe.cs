using Concept_Claves_Interfaces_POO_AP.Interfaces;
using System.Text;

namespace Concept_Claves_Interfaces_POO_AP.Models
{
    class SuperHeroe : Heroe, ISuperHeroe
    //Se hace la implementación extra con la interface
    //Se hace una referencia a la clase heroe para la clase abstract
    {
        //Agregado de la clase 12 encapsulamiento
        private string nom_ver;
        public int Id { get; set; } = 1;
        public override string Nom //Se agrega el metodo sobrecargado que viene de la clase Heroe
        { get
            {
                return nom_ver;
            }

            set
            {
                nom_ver = value.Trim(); //Recordemos que en manipulación de cadenas Trim toma la cadena y elimina los espacios
            }
        }

        public string Nom_SecretId  //Clase sin abstracción pero que usa parte de estas funciones para su implementación
        {
            get
            {
                return $"{Nom } -({SecretId})";
            }
                }
        public string SecretId { get; set; }
        public string City;
        public List<SuperPoder> SuperPoderes = new List<SuperPoder>();
        public bool poderVolar;
        internal string resultSalvarelMundo;

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            poderVolar = false;
            Utl_SuperPoder();

        }

        public string Utl_SuperPoder()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                //Uso de encapsulamiento sin retorno
                sb.AppendLine($"{Nom_SecretId} esta usando el super poder {item.Nombre} !!"); //Cambio de la variable usada en videos anteriores 
               
            }
            return sb.ToString();
        }

        public override string SalvarelMundo() //Metodo sobrecargado para implementar una de las clases abstract
        {
            return $"El {Nom_SecretId} puede que haya salvado al mundo ";
        }
        public override string SalvarLaTierra()
        {
            //return base.salvaerLaTierra();
            return $"{Nom_SecretId} ha salvado la tierra, pero quizas seria mejor no haberla hecho, digo falta la mitad";
        }
    }
}


