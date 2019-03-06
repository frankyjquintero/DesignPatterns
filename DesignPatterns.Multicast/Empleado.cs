using System;

namespace DesignPatterns.Multicast
{
    public abstract class Empleado : IReceptorGeneral
    {
        protected string nombre;

        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }

        public void Recibe(MensajeGeneral mensaje)
        {
            Console.WriteLine("Mensaje general");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Mensaje: ");
            foreach (string linea in mensaje.Contenido)
                Console.WriteLine(linea);
        }
    }
}

