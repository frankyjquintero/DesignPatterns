using System;

public class Usuario
{
    static void Main(string[] args)
    {
        ObjetoBasico vehiculo1 = new Vehiculo(
          "Auto++ KT500 Vehículo de ocasión en buen estado");
        Console.WriteLine(vehiculo1.devuelveDescripcion());
        ObjetoBasico modelo1 = new Modelo("KT400",
          "Vehículo amplio y confortable");
        ObjetoBasico vehiculo2 = new Vehiculo(null);
        vehiculo2.siguiente = modelo1;
        Console.WriteLine(vehiculo2.devuelveDescripcion());
        ObjetoBasico marca1 = new Marca("Auto++",
          "Marca del automóvil", "de gran calidad");
        ObjetoBasico modelo2 = new Modelo("KT700", null);
        modelo2.siguiente = marca1;
        ObjetoBasico vehiculo3 = new Vehiculo(null);
        vehiculo3.siguiente = modelo2;
        Console.WriteLine(vehiculo3.devuelveDescripcion());
        ObjetoBasico vehiculo4 = new Vehiculo(null);
        Console.WriteLine(vehiculo4.devuelveDescripcion());
    }
}
