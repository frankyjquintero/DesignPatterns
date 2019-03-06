using System;

public class Modelo : ObjetoBasico
{
    protected string laDescripcion;
    protected string nombre;

    public Modelo(string nombre, string descripcion)
    {
        this.laDescripcion = descripcion;
        this.nombre = nombre;
    }

    protected override string descripcion
    {
        get
        {
            if (laDescripcion != null)
                return "Modelo " + nombre + " : " + laDescripcion;
            else
                return null;
        }
    }
}
