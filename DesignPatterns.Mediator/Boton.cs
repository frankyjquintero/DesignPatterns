using System;

namespace DesignPatterns.Mediator
{
    public class Boton : Control
    {
        public Boton(string nombre) : base(nombre) { }

        public override void Informa()
        {
            Console.WriteLine("¿Desea activar el botón " +
                              Nombre + " ?");
            string respuesta = Console.ReadLine();
            if (respuesta == "sí")
                this.Modifica();
        }
    }
}