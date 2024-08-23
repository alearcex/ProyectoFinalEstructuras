using System;

namespace arbolbinario
{
    internal class Nodo
    {
        public byte Numero { get; set; }
        public string Valor { get; set; }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }

        public Nodo(string valor, byte numero)
        {
            Numero = numero;
            Valor = valor;
            Izquierdo = null;
            Derecho = null;
        }

        public static Nodo CrearArbol()
        {
            Console.Title = "Proyecto Final Estructuras";

            Nodo nodo1 = new Nodo("Inicio Historia", 1);
            Nodo nodo2 = new Nodo("Ir al Río", 2);
            Nodo nodo3 = new Nodo("Ir a la Casa", 3);
            Nodo nodo4 = new Nodo("El 7", 4);
            Nodo nodo5 = new Nodo("El 8", 5);
            Nodo nodo6 = new Nodo("Detenerse y volver a casa", 6);
            Nodo nodo7 = new Nodo("Buscar la montaña", 7);
            Nodo nodo8 = new Nodo("Detenerse y volver a casa", 8);
            Nodo nodo9 = new Nodo("Escalar la montaña", 9);
            Nodo nodo10 = new Nodo("Acierta", 10);
            Nodo nodo11 = new Nodo("Falla", 11);

            // Asignar hijos a cada nodo
            nodo1.Izquierdo = nodo2;
            nodo1.Derecho = nodo3;

            nodo2.Izquierdo = nodo4;
            nodo2.Derecho = nodo5;

            nodo3.Izquierdo = nodo6;
            nodo3.Derecho = nodo7;

            nodo7.Izquierdo = nodo8;
            nodo7.Derecho = nodo9;

            nodo9.Izquierdo = nodo10;
            nodo9.Derecho = nodo11;

            // Devolver la raíz del árbol
            return nodo1;
        }

        public void RecorrerNodos()
        {
            Nodo nodoActual = this;

            while (nodoActual != null)
            {
                Console.Clear();
                Historia.EscribirHistoria(nodoActual.Numero);
                if (nodoActual.Izquierdo != null && nodoActual.Derecho != null)
                {
                    Console.WriteLine($"1. {nodoActual.Izquierdo.Valor}");
                    Console.WriteLine($"2. {nodoActual.Derecho.Valor}");
                    string eleccion = Console.ReadLine();

                    if (eleccion == "1")
                    {
                        nodoActual = nodoActual.Izquierdo;
                    }
                    else if (eleccion == "2")
                    {
                        nodoActual = nodoActual.Derecho;
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    }
                }
                else
                {
                    Console.WriteLine("Fin, gracias por leer.");
                    nodoActual = null;
                }

                if (nodoActual != null)
                {
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
