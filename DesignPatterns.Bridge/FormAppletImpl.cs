using System;

namespace DesignPatterns.Bridge
{
    public class FormAppletImpl : IFormularioImpl
    {

        public void DibujaTexto(string texto)
        {
            Console.WriteLine("Applet: " + texto);
        }

        public string AdministraZonaIndicada()
        {
            return Console.ReadLine();
        }
    }
}
