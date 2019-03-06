using System;

public class FormHtmlImpl : IFormularioImpl
{

    public void DibujaTexto(string texto)
    {
        Console.WriteLine("HTML: " + texto);
    }

    public string AdministraZonaIndicada()
    {
        return Console.ReadLine();
    }
}
