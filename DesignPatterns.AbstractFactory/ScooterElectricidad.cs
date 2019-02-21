using System;

namespace DesignPatterns.AbstractFactory
{
    public class ScooterElectricidad : Scooter
    {
        public ScooterElectricidad(string modelo, string color, int potencia) : base(modelo, color, potencia)
        {
        }

        public override void mostrarCaracteristicas()
        {
            Console.WriteLine("Scooter electrica de modelo: " + modelo + " de color: " + color + " de potencia: " + potencia);
        }

    }


}
