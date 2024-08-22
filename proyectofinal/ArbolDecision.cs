namespace arbolbinario
{
    internal class ArbolDecision
    {
        public static void MostrarDecision(string decision)
        {
            switch (decision)
            {
                case "1":
                    Historia.MostrarOpcionRío();
                    break;
                case "2":
                    Historia.MostrarOpcionCasa();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intenta nuevamente.");
                    break;
            }
        }

        public static void MostrarDecisionMontaña(string decision)
        {
            switch (decision)
            {
                case "1":
                    Historia.MostrarFinalMontaña();
                    break;
                case "2":
                    Historia.MostrarRegresoSinTesoro();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intenta nuevamente.");
                    break;
            }
        }
    }
}
