using System;

namespace DesignPatterns.Multicast
{
    internal static class Concesionario
    {
        private static void Main(string[] args)
        {
            DireccionGeneral direccionGeneral = new
                DireccionGeneral();
            DireccionComercial direccionComercial = new
                DireccionComercial();
            Comercial comercial1 = new Comercial("Pablo");
            Comercial comercial2 = new Comercial("Enrique");
            Administrativo administrativo = new Administrativo(
                "Juan");
            direccionGeneral.AgregaReceptorGeneral(comercial1);
            direccionGeneral.AgregaReceptorGeneral(comercial2);
            direccionGeneral.AgregaReceptorGeneral
                (administrativo);
            direccionGeneral.EnviaMensajes();
            direccionComercial.AgregaReceptorComercial
                (comercial1);
            direccionComercial.AgregaReceptorComercial
                (comercial2);
            direccionComercial.EnviaMensajes();
            Console.ReadKey();
        }
    }
}

