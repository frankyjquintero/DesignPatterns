using System;

namespace DesignPatterns.Adapter
{
    public class ComponentePdf
    {
        protected string contenido;

        public void PdfFijaContenido(string contenido)
        {
            this.contenido = contenido;
        }


        public void PdfPreparaVisualizacion()
        {
            Console.WriteLine("Visualiza PDF: Comienzo");
        }

        public void PdfRefresca()
        {
            Console.WriteLine("Visualiza contenido PDF: " +
                              contenido);
        }

        public void PdfFinalizaVisualizacion()
        {
            Console.WriteLine("Visualiza PDF: Fin");
        }

        public void PdfEnviaImpresora()
        {
            Console.WriteLine("Impresión PDF: " + contenido);
        }
    }
}
