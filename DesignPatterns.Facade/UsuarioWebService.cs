using System;
using System.Collections.Generic;

namespace DesignPatterns.Facade
{
    public static class UsuarioWebService
    {
        private static void Main(string[] args)
        {
            IWebServiceAuto webServiceAuto = new
                WebServiceAutoImpl();
            Console.WriteLine(webServiceAuto.Documento(0));
            Console.WriteLine(webServiceAuto.Documento(1));
            IList<string> resultados =
                webServiceAuto.BuscaVehiculos(6000, 1000);
            if (resultados.Count > 0)
            {
                Console.WriteLine(
                    "Vehículo(s) cuyo precio está comprendido "+
                    "entre 5000 y 7000");
                foreach (string resultado in resultados)
                    Console.WriteLine("   " + resultado);
            }
            Console.ReadKey();
        }
    }
}
