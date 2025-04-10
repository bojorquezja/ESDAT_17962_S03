using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace listaDoble {
    internal class LEDoble {
        Nodo Primero { get; set; }
        Nodo Ultimo { get; set; }

        //agrega un valor al inicio de LE Doble
        public void AgregaPrimero(int valor) {

        }

        //agrega un valor al final de LE Doble
        public void AgregaFinal(int valor) {
            Nodo nuevo = new Nodo(valor);
            
            if (this.Ultimo == null) {//no hay nodos
                this.Primero = nuevo;
                this.Ultimo = nuevo;
            } else {
                Nodo ult = this.Ultimo;
                this.Ultimo = nuevo;
                ult.Sig = nuevo;
                nuevo.Ant = ult;
            }
        }

        //ve valores separados por comas de la LEDoble
        public override string ToString() {
            string listaVag = "";
            Nodo tmp = this.Primero;
            while (tmp != null) {
                listaVag += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return listaVag;
        }
    }
}
