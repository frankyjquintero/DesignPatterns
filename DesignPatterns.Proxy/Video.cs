using System;

namespace DesignPatterns.Proxy
{
    public class Video : IAnimacion
    {
        public void Clic() { }

        public void Dibuja()
        {
            Console.WriteLine("Mostrar el vídeo");
        }

        public void Carga()
        {
            Console.WriteLine("Cargar el vídeo");
        }

        public void Reproduce()
        {
            Console.WriteLine("Reproducir el vídeo");
        }
    }
}
