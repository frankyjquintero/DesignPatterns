using System;

public class FormAppletImpl : FormularioImpl
{

    public void dibujaTexto(string texto)
    {
        Console.WriteLine("Applet: " + texto);
    }

    public string administraZonaIndicada()
    {
        return Console.ReadLine();
    }
}
