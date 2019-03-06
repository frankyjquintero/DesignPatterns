using System;

public abstract class Elemento
{
    protected string descripcion;

    public Elemento(string descripcion)
    {
        this.descripcion = descripcion;
    }

    public bool palabraClaveValida(string palabraClave)
    {
        return descripcion.IndexOf(palabraClave) != -1;
    }
}
