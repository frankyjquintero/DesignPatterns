using System;

public class AutomovilGasolina : Automovil
{

    public override void visualizaCaracteristicas()
    {
        Console.WriteLine(
         "Automóvil de gasolina de modelo: " + modelo +
         " de color: " + color + " de potencia: " +
         potencia + " de espacio: " + espacio);
    }
}

