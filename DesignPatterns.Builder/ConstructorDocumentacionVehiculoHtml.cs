using System;

public class ConstructorDocumentacionVehiculoHtml :
  ConstructorDocumentacionVehiculo
{
    public ConstructorDocumentacionVehiculoHtml()
    {
        documentacion = new DocumentacionHtml();
    }

    public override void construyeSolicitudPedido(string
      nombreCliente)
    {
        string documento;
        documento = "<HTML>Solicitud de pedido Cliente: " +
          nombreCliente + "</HTML>";
        documentacion.agregaDocumento(documento);
    }

    public override void construyeSolicitudMatriculacion
      (string nombreSolicitante)
    {
        string documento;
        documento =
        "<HTML>Solicitud de matriculación Solicitante: " +
        nombreSolicitante + "</HTML>";
        documentacion.agregaDocumento(documento);
    }
}

