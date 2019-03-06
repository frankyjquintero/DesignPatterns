using System;

public class ScooterGasolina : Scooter
{

    public override void visualizaCaracteristicas()
    {
        Console.WriteLine("Scooter de gasolina de modelo: " +
         modelo + " de color: " + color +
         " de potencia: " + potencia);
    }
}


