using System;

class Program
{
    static void Main(string[] args)
    {
        Automovil protoAutomovilEstandarAzul = new
         AutomovilElectricidad();
        protoAutomovilEstandarAzul.modelo = "estándar";
        protoAutomovilEstandarAzul.color = "azul";

        Scooter protoScooterClasicoRojo = new ScooterGasolina();
        protoScooterClasicoRojo.modelo = "clasico";
        protoScooterClasicoRojo.color = "rojo";

        FabricaVehiculo fabrica = new FabricaVehiculo();
        fabrica.prototypeAutomovil =
         protoAutomovilEstandarAzul;
        fabrica.prototypeScooter = protoScooterClasicoRojo;

        Automovil auto = fabrica.creaAutomovil();
        auto.visualizaCaracteristicas();
        Scooter scooter = fabrica.creaScooter();
        scooter.visualizaCaracteristicas();
    }
}

