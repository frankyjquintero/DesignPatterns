using System;

namespace DesignPatterns.Visitor
{
    public class VisitanteMailingComercial : IVisitante
    {
        public void Visita(EmpresaSinFilial
            empresa)
        {
            Console.WriteLine("Envía un email a " +
                              empresa.Nombre + " dirección: " + empresa.Email
                              + " Propuesta comercial para su empresa");
        }

        public void Visita(EmpresaMadre empresa)
        {
            Console.WriteLine("Envía un email a " +
                              empresa.Nombre + " dirección: " + empresa.Email
                              + " Propuesta comercial para su grupo");
            Console.WriteLine("Impresión de un correo electrónico para " +
                              empresa.Nombre + " dirección: " +
                              empresa.Direccion +
                              " Propuesta comercial para su grupo");
        }
    }
}
