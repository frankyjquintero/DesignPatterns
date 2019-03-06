using System;

namespace DesignPatterns.Builder
{
    public class DocumentacionPdf : Documentacion
    {
        public override void AgregaDocumento(string documento)
        {
            if (documento.StartsWith("<PDF>"))
                contenido.Add(documento);
        }

        public override void Imprime()
        {
            Console.WriteLine("Documentación PDF");
            foreach (string s in contenido)
                Console.WriteLine(s);
        }
    }
}
