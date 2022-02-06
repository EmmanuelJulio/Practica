using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Auto
    {
        public int CantidadDePuertas { get; }
        public int Año { get; }
        public string Modelo { get; }
        public Auto(int cantidadDePuertas,int Año,string Modelo)
        {
            CantidadDePuertas = cantidadDePuertas;
            this.Año = Año;
            this.Modelo = Modelo;
        }
        public void Arracar()
        {
            Console.WriteLine("Arrancando el " + Modelo + " cuyo año es el " + Año);
        }

        
    }
}
