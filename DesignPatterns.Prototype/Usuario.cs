using System;

namespace DesignPatterns.Prototype
{
    public class Usuario
    {
        static void Main(string[] args)
        {
            DocumentacionEnBlanco documentacionEnBlanco = DocumentacionEnBlanco.Instance();
            documentacionEnBlanco.Incluye(new OrdenDePedido());
            documentacionEnBlanco.Incluye(new CertificadoCesion());
            documentacionEnBlanco.Incluye(new SolicitudMatriculacion());
            // creación de documentación nueva para dos clientes
            DocumentacionCliente documentacionCliente1 = new DocumentacionCliente(
                "Martín");
            DocumentacionCliente documentacionCliente2 = new DocumentacionCliente(
                "Simón");
            documentacionCliente1.Visualiza();
            documentacionCliente2.Visualiza();
            Console.ReadKey();
        }
    }
}
