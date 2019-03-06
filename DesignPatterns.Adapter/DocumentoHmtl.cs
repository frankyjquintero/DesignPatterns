using System;

public class DocumentoHtml : IDocumento
{
    protected string _contenido;

    public string Contenido
    {
        protected get => _contenido;
        set => _contenido = value;
    }

    public void Dibuja()
    {
        Console.WriteLine("Dibuja el documento HTML: " +
          Contenido);
    }

    public void Imprime()
    {
        Console.WriteLine("Imprime el documento HTML: " +
          Contenido);
    }

}
