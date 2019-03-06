using System;

namespace DesignPatterns.Strategy
{
    public static class Usuario
    {
        static void Main(string[] args)
        {
            VistaCatalogo vistaCatalogo1 = new VistaCatalogo(new
                DibujaTresVehiculosPorLinea());
            vistaCatalogo1.Dibuja();
            VistaCatalogo vistaCatalogo2 = new VistaCatalogo(new
                DibujaUnVehiculoPorLinea());
            vistaCatalogo2.Dibuja();
            Console.ReadKey();
        }
    }
}
