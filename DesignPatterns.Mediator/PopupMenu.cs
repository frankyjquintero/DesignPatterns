using System;
using System.Collections.Generic;

public class PopupMenu : Control
{
    protected IList<string> opciones =
        new List<string>();

    public PopupMenu(string nombre) : base(nombre) { }

    public override void informa()
    {
        Console.WriteLine("Información de: " + nombre);
        Console.WriteLine("Valor actual: " + valor);
        for (int indice = 0; indice < opciones.Count; indice++)
            Console.WriteLine("- " + indice + " )" +
              opciones[indice]);
        int eleccion = int.Parse(Console.ReadLine());
        if ((eleccion >= 0) && (eleccion < opciones.Count))
        {
            bool cambia = (valor != opciones[eleccion]);
            if (cambia)
            {
                valor = opciones[eleccion];
                this.modifica();
            }
        }
    }

    public void agregaOpcion(string opcion)
    {
        opciones.Add(opcion);
    }
}
