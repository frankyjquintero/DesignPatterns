using System;

namespace DesignPatterns.PluggableFactory
{
    public class ScooterElectricidad : Scooter
    {

        public override void VisualizaCaracteristicas()
        {
            Console.WriteLine("Scooter eléctrica de modelo: "
                              + Modelo + " de color: " + Color +
                              " de potencia: " + Potencia);
        }
    }
}

