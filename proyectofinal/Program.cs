using System;

namespace arbolbinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Historia.MostrarHistoriaCompleta();
            Console.WriteLine(
                "Ahora debes tomar una decisión:\n" +
                "1. Dirígete al río\n" +
                "2. Ir hacia la casa\n");
            string decision = Console.ReadLine();
            ArbolDecision.MostrarDecision(decision);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Fin, gracias por leer.");
            Console.ResetColor();
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
