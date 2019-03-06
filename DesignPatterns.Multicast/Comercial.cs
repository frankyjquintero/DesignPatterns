using System;

namespace DesignPatterns.Multicast
{
    public class Comercial : Empleado, IReceptorComercial
    {
        public Comercial(string nombre)
            : base(nombre)
        {
        }

        public void Recibe(MensajeComercial mensaje)
        {
            Console.WriteLine("Mensaje comercial");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Mensaje: " +
                              mensaje.Contenido
            );
        }
    }
}


