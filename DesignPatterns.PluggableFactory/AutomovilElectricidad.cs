using System;

namespace DesignPatterns.PluggableFactory
{
    public class AutomovilElectricidad : Automovil
    {

        public override void VisualizaCaracteristicas()
        {
            Console.WriteLine(
                "Automóvil eléctrico de modelo: " + Modelo +
                " de color: " + Color + " de potencia: " +
                Potencia + " de espacio: " + Espacio);
        }
    }
}


