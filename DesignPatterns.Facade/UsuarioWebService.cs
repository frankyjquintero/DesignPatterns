using System;
using System.Collections.Generic;

public class UsuarioWebService
{
  static void Main(string[] args)
  {
    WebServiceAuto webServiceAuto = new
      WebServiceAutoImpl();
    Console.WriteLine(webServiceAuto.documento(0));
    Console.WriteLine(webServiceAuto.documento(1));
    IList<string> resultados =
      webServiceAuto.buscaVehiculos(6000, 1000);
    if (resultados.Count > 0)
    {
      Console.WriteLine(
        "Vehículo(s) cuyo precio está comprendido "+
        "entre 5000 y 7000");
      foreach (string resultado in resultados)
        Console.WriteLine("   " + resultado);
    }
  }
}
