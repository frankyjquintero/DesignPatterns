using System;

namespace DesignPatterns.AbstractFactory
{
    public class AutomovilElectricidad : Automovil
    {
        public AutomovilElectricidad(string modelo, string
                                     color, int potencia, double espacio)
            : base(modelo,
                color, potencia, espacio)
        { }
        public override void MostrarCaracteristicas()
        {
            Console.WriteLine(
                "Automóvil eléctrico de modelo: " + modelo +
                " de color: " + color + " de potencia: " +
                potencia + " de espacio: " + espacio);
            Console.ReadKey();
        }
    }



}
