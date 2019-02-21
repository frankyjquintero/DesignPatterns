using System;

public class ClienteVehiculo
{
    static void Main(string[] args)
    {
        ConstructorDocumentacionVehiculo constructor;
        Console.WriteLine("Desea generar " +
          "documentación HTML (1) o PDF (2):");
        string seleccion = Console.ReadLine();
        if (seleccion == "1")
        {
            constructor = new ConstructorDocumentacionVehiculoHtml();
        }
        else
        {
            constructor = new ConstructorDocumentacionVehiculoPdf();
        }
        Vendedor vendedor = new Vendedor(constructor);
        Documentacion documentacion = vendedor.construye("Martín");
        documentacion.imprime();
        Console.ReadKey();
    }
}
