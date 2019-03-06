using System;

namespace DesignPatterns.PluggableFactory
{
    public class ScooterGasolina : Scooter
    {

        public override void VisualizaCaracteristicas()
        {
            Console.WriteLine("Scooter de gasolina de modelo: " +
                              Modelo + " de color: " + Color +
                              " de potencia: " + Potencia);
        }
    }
}


