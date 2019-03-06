using System;

namespace DesignPatterns.PluggableFactory
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Automovil protoAutomovilEstandarAzul = new
                AutomovilElectricidad();
            protoAutomovilEstandarAzul.Modelo = "estándar";
            protoAutomovilEstandarAzul.Color = "azul";

            Scooter protoScooterClasicoRojo = new ScooterGasolina();
            protoScooterClasicoRojo.Modelo = "clasico";
            protoScooterClasicoRojo.Color = "rojo";

            FabricaVehiculo fabrica = new FabricaVehiculo();
            fabrica.PrototypeAutomovil =
                protoAutomovilEstandarAzul;
            fabrica.PrototypeScooter = protoScooterClasicoRojo;

            Automovil auto = fabrica.CreaAutomovil();
            auto.VisualizaCaracteristicas();
            Scooter scooter = fabrica.CreaScooter();
            scooter.VisualizaCaracteristicas();
            Console.ReadKey();
        }
    }
}

