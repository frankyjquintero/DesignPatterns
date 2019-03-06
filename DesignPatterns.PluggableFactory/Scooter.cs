using System;

public abstract class Scooter
{
    public string modelo { get; set; }
    public string color { get; set; }
    protected int potencia { get; set; }

    public Scooter duplica()
    {
        Scooter resultado;
        resultado = (Scooter)this.MemberwiseClone();
        return resultado;
    }

    public abstract void visualizaCaracteristicas();
}

