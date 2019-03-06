using System;

public class FormHtmlImpl : FormularioImpl
{

    public void dibujaTexto(string texto)
    {
        Console.WriteLine("HTML: " + texto);
    }

    public string administraZonaIndicada()
    {
        return Console.ReadLine();
    }
}
