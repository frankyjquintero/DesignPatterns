using System;

public abstract class Empleado : ReceptorGeneral
{
    protected string nombre;

    public Empleado(string nombre)
    {
        this.nombre = nombre;
    }

    public void recibe(MensajeGeneral mensaje)
    {
        Console.WriteLine("Mensaje general");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Mensaje: ");
        foreach (string linea in mensaje.contenido)
            Console.WriteLine(linea);
    }
}

