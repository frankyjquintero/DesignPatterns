using System;

public abstract class Control
{
    public string valor { get; protected set; }
    public Formulario director { get; set; }
    public string nombre { get; protected set; }

    public Control(string nombre)
    {
        this.valor = "";
        this.nombre = nombre;
    }

    public abstract void informa();

    protected void modifica()
    {
        director.controlModificado(this);
    }
}
