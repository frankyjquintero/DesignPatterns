using System;

public class AutomovilElectricidad : Automovil
{

    public override void visualizaCaracteristicas()
    {
        Console.WriteLine(
         "Automóvil eléctrico de modelo: " + modelo +
         " de color: " + color + " de potencia: " +
         potencia + " de espacio: " + espacio);
    }
}


