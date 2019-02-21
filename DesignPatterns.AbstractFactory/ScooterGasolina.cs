using System;

namespace DesignPatterns.AbstractFactory
{
    public class ScooterGasolina : Scooter
    {
        public ScooterGasolina(string modelo, string color, int potencia) : base(modelo, color, potencia)
        {
        }

        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("Scooter de gasolina de modelo: " + modelo + " de color: " + color + " de potencia: " + potencia);
        }

    }


}
