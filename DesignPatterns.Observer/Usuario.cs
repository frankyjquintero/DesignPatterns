using System;

namespace DesignPatterns.Observer
{
    public static class Usuario
    {
        private static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Descripcion = "Vehículo económico";
            vehiculo.Precio = 5000.0;
            VistaVehiculo vistaVehiculo = new VistaVehiculo(vehiculo);
            vistaVehiculo.Redibuja();
            vehiculo.Precio = 4500.0;
            VistaVehiculo vistaVehiculo2 = new VistaVehiculo(vehiculo);
            vehiculo.Precio = 5500.0;
            Console.ReadKey();
        }
    }
}
