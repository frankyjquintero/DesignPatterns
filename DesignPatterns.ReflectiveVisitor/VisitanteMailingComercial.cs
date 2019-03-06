using System;

public class VisitanteMailingComercial : Visitante, VisitanteEmpresa
{
    public void visita(EmpresaSinFilial empresa)
    {
        Console.WriteLine("Envía un correo a " +
         empresa.nombre + " dirección: " + empresa.email
         + " Propuesta comercial para su empresa");
    }

    public void visita(EmpresaMadre empresa)
    {
        Console.WriteLine("Envía un correo a " +
      empresa.nombre + " dirección: " + empresa.email
      + " Propuesta comercial para su grupo");
        Console.WriteLine("Impresión de un correo para " +
         empresa.nombre + " dirección: " +
         empresa.direccion +
         " Propuesta comercial para su grupo");
        foreach (Empresa filial in empresa.filiales)
            this.iniciaVisita(filial);
    }
}
