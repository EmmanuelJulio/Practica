// See https://aka.ms/new-console-template for more information
using Practica;


int x = 0;
List<Auto> Autos = new List<Auto>();
//while (x<=2)
//{
//    Console.WriteLine("Ingrese la cantidad de puertas");
//    int puertas = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Ingrese el año");
//    int modelo = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Ingrese la Marca");
//    string marca = Console.ReadLine();
//    Console.Clear();
//    Auto OAuto = new Auto(puertas, modelo, marca);
//    Autos.Add(OAuto);
//    x= x+1;
//}

var OAuto1 = new Auto(4, 1992, "Fiat");
var OAuto2 = new Auto(5, 2019, "Ford");
var OAuto3 = new Auto(3, 1992, "Renault");

Autos.Add(OAuto1);
Autos.Add(OAuto2);
Autos.Add(OAuto3);

Concecionaria concecionaria = new Concecionaria(Autos, "Lo de Cacho");
concecionaria.SetConcecionariaNombre("Pepe");
foreach(Auto Oauto in concecionaria.autos)
{
    Oauto.Arracar();
}


Console.ReadKey();
