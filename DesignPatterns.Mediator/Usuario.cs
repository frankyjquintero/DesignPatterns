using System;

namespace DesignPatterns.Mediator
{
    public static class Usuario
    {
        static void Main(string[] args)
        {
            Formulario formulario = new Formulario();
            formulario.AgregaControl(new ZonaInformacion("Nombre"));
            formulario.AgregaControl(new ZonaInformacion("Apellidos"));
            PopupMenu menu = new PopupMenu("Coprestatario");
            menu.AgregaOpcion("sin coprestatario");
            menu.AgregaOpcion("con coprestatario");
            formulario.AgregaControl(menu);
            formulario.MenuCoprestatario = menu;
            Boton boton = new Boton("OK");
            formulario.AgregaControl(boton);
            formulario.BotonOk = boton;
            formulario.AgregaControlCoprestatario(new ZonaInformacion(
                "Nombre del coprestatario"));
            formulario.AgregaControlCoprestatario(new ZonaInformacion(
                "Apellidos del coprestatario"));
            formulario.Informa();
            Console.ReadKey();
        }
    }
}
