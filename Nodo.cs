using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    public class Nodo
    {
        public Nodo(string pNombre)
        {
            this.Nombre = pNombre;
        }
        public Nodo(string pNombre, Nodo pIzq, Nodo pDer) : this(pNombre)
        {
            this.Izq = pIzq;
            this.Der = pDer;
        }
        public string Nombre { get; set; }
        public Nodo Izq { get; set; }
        public Nodo Der { get; set; }
    }

}
