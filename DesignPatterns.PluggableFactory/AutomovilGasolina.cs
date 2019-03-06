using System;

namespace DesignPatterns.PluggableFactory
{
    public class AutomovilGasolina : Automovil
    {

        public override void VisualizaCaracteristicas()
        {
            Console.WriteLine(
                "Automóvil de gasolina de modelo: " + Modelo +
                " de color: " + Color + " de potencia: " +
                Potencia + " de espacio: " + Espacio);
        }
    }
}

