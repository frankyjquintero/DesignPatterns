using System;

public class ScooterElectricidad : Scooter
{

    public override void visualizaCaracteristicas()
    {
        Console.WriteLine("Scooter eléctrica de modelo: "
         + modelo + " de color: " + color +
         " de potencia: " + potencia);
    }
}

