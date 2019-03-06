using System;

namespace DesignPatterns.ReflectiveVisitor
{
    public class VisitanteMailingComercial : Visitante, IVisitanteEmpresa
    {
        public void Visita(EmpresaSinFilial empresa)
        {
            Console.WriteLine("Envía un correo a " +
                              empresa.Nombre + " dirección: " + empresa.Email
                              + " Propuesta comercial para su empresa");
        }

        public void Visita(EmpresaMadre empresa)
        {
            Console.WriteLine("Envía un correo a " +
                              empresa.Nombre + " dirección: " + empresa.Email
                              + " Propuesta comercial para su grupo");
            Console.WriteLine("Impresión de un correo para " +
                              empresa.Nombre + " dirección: " +
                              empresa.Direccion +
                              " Propuesta comercial para su grupo");
            foreach (Empresa filial in empresa.Filiales)
                this.IniciaVisita(filial);
        }
    }
}
