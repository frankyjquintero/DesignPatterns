using System;

public class VisitanteMailingComercial : Visitante
{
    public void visita(EmpresaSinFilial
      empresa)
    {
        Console.WriteLine("Envía un email a " +
          empresa.nombre + " dirección: " + empresa.email
          + " Propuesta comercial para su empresa");
    }

    public void visita(EmpresaMadre empresa)
    {
        Console.WriteLine("Envía un email a " +
          empresa.nombre + " dirección: " + empresa.email
          + " Propuesta comercial para su grupo");
        Console.WriteLine("Impresión de un correo electrónico para " +
          empresa.nombre + " dirección: " +
          empresa.direccion +
          " Propuesta comercial para su grupo");
    }
}
