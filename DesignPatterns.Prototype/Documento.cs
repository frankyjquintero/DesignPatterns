using System;

public abstract class Documento
{
    protected string contenido = "";

    public Documento duplica()
    {
        Documento resultado;
        resultado = (Documento)this.MemberwiseClone();
        return resultado;
    }

    public void rellena(string informacion)
    {
        contenido = informacion;
    }

    public abstract void imprime();
    public abstract void visualiza();
}
