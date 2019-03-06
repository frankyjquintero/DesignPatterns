using System;

public class Usuario
{
    static void Main(string[] args)
    {
        Vehiculo vehiculo1 = new Vehiculo("A01", 1, 1000.0);
        Vehiculo vehiculo2 = new Vehiculo("A11", 6, 2000.0);
        Vehiculo vehiculo3 = new Vehiculo("Z03", 2, 3000.0);
        Catalogo catalogo = new Catalogo();
        catalogo.agrega(vehiculo1);
        catalogo.agrega(vehiculo2);
        catalogo.agrega(vehiculo3);
        Console.WriteLine("Visualización inicial del catálogo");
        catalogo.visualiza();
        Console.WriteLine();
        SolicitudRebaja solicitudRebaja = new SolicitudRebaja
          (10, 5, 0.1);
        catalogo.ejecutaSolicitudRebaja(solicitudRebaja);
        Console.WriteLine("Visualización del catálogo tras " +
          "ejecutar la primera solicitud");
        catalogo.visualiza();
        Console.WriteLine();
        SolicitudRebaja solicitudRebaja2 = new SolicitudRebaja
          (10, 5, 0.5);
        catalogo.ejecutaSolicitudRebaja(solicitudRebaja2);
        Console.WriteLine("Visualización del catálogo tras " +
          "ejecutar la segunda solicitud");
        catalogo.visualiza();
        Console.WriteLine();
        catalogo.anulaSolicitudRebaja(1);
        Console.WriteLine("Visualización del catálogo tras " +
          "anular la primera solicitud");
        catalogo.visualiza();
        Console.WriteLine();
        catalogo.restableceSolicitudRebaja(1);
        Console.WriteLine("Visualización del catálogo tras " +
          "restablecer la primera solicitud");
        catalogo.visualiza();
        Console.WriteLine();
    }
}
