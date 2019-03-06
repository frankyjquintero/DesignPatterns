using System;

namespace DesignPatterns.Bridge
{
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
}
