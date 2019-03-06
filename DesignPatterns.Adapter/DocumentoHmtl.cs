using System;

namespace DesignPatterns.Adapter
{
    public class DocumentoHtml : IDocumento
    {
        protected string contenido;

        public string Contenido
        {
            protected get => contenido;
            set => contenido = value;
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
}
