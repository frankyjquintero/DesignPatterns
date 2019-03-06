using System;

public class Comercial : Empleado, ReceptorComercial
{
    public Comercial(string nombre)
        : base(nombre)
    {
    }

    public void recibe(MensajeComercial mensaje)
    {
        Console.WriteLine("Mensaje comercial");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Mensaje: " +
         mensaje.contenido
         );
    }
}


