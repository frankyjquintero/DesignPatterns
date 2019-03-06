using System;

class Concesionario
{
    static void Main(string[] args)
    {
        DireccionGeneral direccionGeneral = new
      DireccionGeneral();
        DireccionComercial direccionComercial = new
      DireccionComercial();
        Comercial comercial1 = new Comercial("Pablo");
        Comercial comercial2 = new Comercial("Enrique");
        Administrativo administrativo = new Administrativo(
         "Juan");
        direccionGeneral.agregaReceptorGeneral(comercial1);
        direccionGeneral.agregaReceptorGeneral(comercial2);
        direccionGeneral.agregaReceptorGeneral
         (administrativo);
        direccionGeneral.enviaMensajes();
        direccionComercial.agregaReceptorComercial
         (comercial1);
        direccionComercial.agregaReceptorComercial
         (comercial2);
        direccionComercial.enviaMensajes();
    }
}

