using System;

public class ServidorWeb
{
    private static void Main(string[] args)
    {
        IDocumento documento1, documento2;
        documento1 = new DocumentoHtml
        {
            Contenido = "Hello"
        };
        documento1.Dibuja();
        Console.WriteLine();
        documento2 = new DocumentoPdf
        {
            Contenido = "Hola"
        };
        documento2.Dibuja();
        Console.ReadKey();
    }
}
