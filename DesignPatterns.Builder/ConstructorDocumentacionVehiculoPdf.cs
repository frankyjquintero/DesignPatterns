using System;

public class ConstructorDocumentacionVehiculoPdf :
  ConstructorDocumentacionVehiculo
{
    public ConstructorDocumentacionVehiculoPdf()
    {
        documentacion = new DocumentacionPdf();
    }

    public override void construyeSolicitudPedido(string
      nombreCliente)
    {
        string documento;
        documento = "<PDF>Solicitud de pedido Cliente: " +
          nombreCliente + "</PDF>";
        documentacion.agregaDocumento(documento);
    }

    public override void construyeSolicitudMatriculacion
      (string nombreSolicitante)
    {
        string documento;
        documento =
        "<PDF>Solicitud de matriculación Solicitante: " +
        nombreSolicitante + "</PDF>";
        documentacion.agregaDocumento(documento);
    }
}
