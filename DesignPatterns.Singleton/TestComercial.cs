using System;

namespace DesignPatterns.Singleton
{
    public static class TestComercial
    {
        static void Main(string[] args)
        {
            // inicialización del comercial en el sistema
            Comercial elComercial = Comercial.Instance();
            elComercial.Nombre = "Comercial Auto";
            elComercial.Direccion = "Madrid";
            elComercial.Email = "comercial@comerciales.com";
            // muestra el comercial del sistema
            Visualiza();
            Console.ReadKey();
        }

        public static void Visualiza()
        {
            Comercial elComercial = Comercial.Instance();
            elComercial.Visualiza();
        }
    }
}
