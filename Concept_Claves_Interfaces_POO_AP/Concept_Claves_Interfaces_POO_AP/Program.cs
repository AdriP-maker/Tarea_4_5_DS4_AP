using Concept_Claves_Interfaces_POO_AP;
using Concept_Claves_Interfaces_POO_AP.Models;
var imprimirInfo = new PrintInfo(); //Nueva variable que se usa para llamar a la interfaz

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear";
poderVolar.Nivel = NivelPoder.NivelDos;
poderVolar.Tipo = TipoPoder.Movimiento;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;
superFuerza.Tipo = TipoPoder.Combate;

var regeneracion = new SuperPoder();
superFuerza.Nombre = "Regeneracion";
superFuerza.Nivel = NivelPoder.NivelTres;
superFuerza.Tipo = TipoPoder.Soporte;

var superman = new SuperHeroe();

superman.Id = 1;
superman.Nom = "      Superman     "; //Prueba para el encapsulamiento
superman.SecretId = "Clark Kent";
superman.City = "Metropolis";
superman.poderVolar = true;

//Se agrega el nuevo llamado y uso de esta variable de la interfaz

imprimirInfo.Print_Sup_Heroe(superman);

//Clase 12 en adelante eliminación de la instancia extra

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.Utl_SuperPoder();
Console.WriteLine(resultSuperPoderes);
//Agregado de la salida de la clase abstract
string resultSalvarMundo = superman.SalvarelMundo();
Console.WriteLine(resultSalvarMundo);
string resultTierra = superman.SalvarLaTierra();
Console.WriteLine(resultTierra);

//Clase 13 herencia
var deadpool = new AntiHeroe();
deadpool.Id = 4;
deadpool.Nom = "Deadpool";
deadpool.SecretId = "Wade Wilson";
deadpool.poderVolar = false;

//Se agrega de igual forma en la parte del nuevo antiheroe
imprimirInfo.Print_Sup_Heroe(deadpool);

//Lista de poderes para Deadpool
List<SuperPoder> poderesDeadpool = new List<SuperPoder>();
poderesDeadpool.Add(regeneracion);
poderesDeadpool.Add(superFuerza);
deadpool.SuperPoderes = poderesDeadpool;
string resultdeadpool = deadpool.Utl_SuperPoder();
Console.WriteLine(resultdeadpool);

//Llamada del metodo de la clase antiheroe por el que realiza una acción
string act_AntiHeroe = deadpool.Contr_Act_Heroe("Beber en el trabajo");
Console.WriteLine(act_AntiHeroe);


enum NivelPoder
{
    NivelUno, NivelDos,NivelTres
}

enum TipoPoder
{
    Combate, Soporte, Manipulación, Movimiento
}

public record SuperHeroeReporte(int Id, string Nombre, string Id_Secret);