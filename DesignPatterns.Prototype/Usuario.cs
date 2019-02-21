using System;

public class Usuario
{
    static void Main(string[] args)
    {
        DocumentacionEnBlanco documentacionEnBlanco = DocumentacionEnBlanco.Instance();
        documentacionEnBlanco.incluye(new OrdenDePedido());
        documentacionEnBlanco.incluye(new CertificadoCesion());
        documentacionEnBlanco.incluye(new SolicitudMatriculacion());
        // creación de documentación nueva para dos clientes
        DocumentacionCliente documentacionCliente1 = new DocumentacionCliente(
        "Martín");
        DocumentacionCliente documentacionCliente2 = new DocumentacionCliente(
        "Simón");
        documentacionCliente1.visualiza();
        documentacionCliente2.visualiza();
        Console.ReadKey();
    }
}
