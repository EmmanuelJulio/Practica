using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Concecionaria
    {
        public List<Auto> autos = new List<Auto>(); 
        public string NombreConcecionaria { get; private set; }
        public Concecionaria(List<Auto> autos,string nombreConcecionaria)
        {
            this.autos = autos;
            NombreConcecionaria = nombreConcecionaria;
        }
        public void SetConcecionariaNombre(string NombreNuevo)
        {
            NombreConcecionaria = NombreNuevo;
        }

        
    }
}
