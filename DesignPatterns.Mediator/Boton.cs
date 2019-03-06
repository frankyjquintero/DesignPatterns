using System;

public class Boton : Control
{
    public Boton(string nombre) : base(nombre) { }

    public override void informa()
    {
        Console.WriteLine("¿Desea activar el botón " +
          nombre + " ?");
        string respuesta = Console.ReadLine();
        if (respuesta == "sí")
            this.modifica();
    }
}