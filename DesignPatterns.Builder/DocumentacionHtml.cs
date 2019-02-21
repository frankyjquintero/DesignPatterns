using System;

public class DocumentacionHtml : Documentacion
{
    public override void agregaDocumento(string documento)
    {
        if (documento.StartsWith("<HTML>"))
            contenido.Add(documento);
    }

    public override void imprime()
    {
        Console.WriteLine("Documentación HTML");
        foreach (string s in contenido)
            Console.WriteLine(s);
    }
}
