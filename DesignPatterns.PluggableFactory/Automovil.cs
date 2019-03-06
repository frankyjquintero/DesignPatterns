using System;

public abstract class Automovil
{
    public string modelo { get; set; }
    public string color { get; set; }
    public int potencia { get; set; }
    public double espacio { get; set; }

    public Automovil duplica()
    {
        Automovil resultado;
        resultado = (Automovil)this.MemberwiseClone();
        return resultado;
    }

    public abstract void visualizaCaracteristicas();
}


