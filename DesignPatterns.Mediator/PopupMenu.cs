using System;
using System.Collections.Generic;

namespace DesignPatterns.Mediator
{
    public class PopupMenu : Control
    {
        protected IList<string> opciones =
            new List<string>();

        public PopupMenu(string nombre) : base(nombre) { }

        public override void Informa()
        {
            Console.WriteLine("Información de: " + Nombre);
            Console.WriteLine("Valor actual: " + Valor);
            for (int indice = 0; indice < opciones.Count; indice++)
                Console.WriteLine("- " + indice + " )" +
                                  opciones[indice]);
            int eleccion = int.Parse(Console.ReadLine());
            if ((eleccion >= 0) && (eleccion < opciones.Count))
            {
                bool cambia = (Valor != opciones[eleccion]);
                if (cambia)
                {
                    Valor = opciones[eleccion];
                    this.Modifica();
                }
            }
        }

        public void AgregaOpcion(string opcion)
        {
            opciones.Add(opcion);
        }
    }
}
