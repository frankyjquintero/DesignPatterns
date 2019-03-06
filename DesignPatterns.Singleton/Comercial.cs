using System;

namespace DesignPatterns.Singleton
{
    public class Comercial
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        private static Comercial _instance = null;

        private Comercial()
        {
        }

        public static Comercial Instance()
        {
            if (_instance == null)
                _instance = new Comercial();
            return _instance;
        }

        public void Visualiza()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Email: " + Email);
        }
    }
}