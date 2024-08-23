using System;

namespace arbolbinario
{
    public class Programa
    {
        public static void Main(string[] args)
        { 
            Nodo raiz = Nodo.CrearArbol();
            raiz.RecorrerNodos();
        }
    }
}
