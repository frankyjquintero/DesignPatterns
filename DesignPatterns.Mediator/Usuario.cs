using System;
public class Usuario
{
    static void Main(string[] args)
    {
        Formulario formulario = new Formulario();
        formulario.agregaControl(new ZonaInformacion("Nombre"));
        formulario.agregaControl(new ZonaInformacion("Apellidos"));
        PopupMenu menu = new PopupMenu("Coprestatario");
        menu.agregaOpcion("sin coprestatario");
        menu.agregaOpcion("con coprestatario");
        formulario.agregaControl(menu);
        formulario.menuCoprestatario = menu;
        Boton boton = new Boton("OK");
        formulario.agregaControl(boton);
        formulario.botonOK = boton;
        formulario.agregaControlCoprestatario(new ZonaInformacion(
          "Nombre del coprestatario"));
        formulario.agregaControlCoprestatario(new ZonaInformacion(
          "Apellidos del coprestatario"));
        formulario.informa();
    }
}
